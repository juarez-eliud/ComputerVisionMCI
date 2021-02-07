using ComputerVisionMCI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ComputerVisionMCI
{
    class PLC
    {
        libnodave.daveOSserialType daveSerial;
        libnodave.daveInterface daveInterface;
        libnodave.daveConnection daveConnection;
        ConnectionSettings _conSet;

        readonly int dataBlock = 1000;

        public string status = "";

        public PLC(ConnectionSettings conSet)
        {
            _conSet = conSet;
        }

        public void Initiate()
        {          
            if (ConnectPLC())
            {
                status = "Conectado";
                Console.WriteLine(status);
                Thread heartBeat = new Thread(HeartBeat);
                heartBeat.Start();

            }
            else
            {
                status = $"Sin conexión a la IP: {_conSet.IP}, reintentando...";
                Console.WriteLine(status);
                Thread.Sleep(60000);
                Initiate();
            }

        }

        public void HeartBeat()
        {
            byte[] on = BitConverter.GetBytes(255);
            byte[] off = BitConverter.GetBytes(0);

            while (true)
            {
                try
                {
                    //Heart Beat
                    daveConnection.writeBits(libnodave.daveDB, dataBlock, 0, 1, on);
                    daveConnection.writeBits(libnodave.daveDB, dataBlock, 0, 1, off);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }


        }






        public bool ConnectPLC()
        {            
            try
            {
                daveSerial.rfd = libnodave.openSocket(_conSet.Port, _conSet.IP);
                daveSerial.wfd = daveSerial.rfd;

                if (daveSerial.rfd > 0)
                {
                    daveInterface = new libnodave.daveInterface(daveSerial, "", 0, libnodave.daveProtoISOTCP, libnodave.daveSpeed187k);
                    daveInterface.setTimeout(1000000);
                    if (0 == daveInterface.initAdapter())
                    {
                        daveConnection = new libnodave.daveConnection(daveInterface, 0, _conSet.Rack, _conSet.Slot);
                        if (0 == daveConnection.connectPLC())
                        {
                            return true;
                        }
                        else
                        {
                            daveConnection.disconnectPLC();
                            libnodave.closeSocket(daveSerial.rfd);
                            return false;
                        }
                    }
                    else
                    {
                        daveInterface.disconnectAdapter();              
                        libnodave.closeSocket(daveSerial.rfd);
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {                
                Console.WriteLine(ex.Message);
                return false;
            }


        }





    }
}
