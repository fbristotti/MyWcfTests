using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ClientApp.Messenger;
using ClientApp.NumberSvc;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var msg = new ChannelFactory<IMessenger>("NetMsmqBinding_IMessenger");
            var msgChannel = msg.CreateChannel();
            msgChannel.SendMessage("kkk");

            var cf = new ChannelFactory<IComplexNumber>("BasicHttpBinding_IComplexNumber");
            var channel = cf.CreateChannel();

            var z1 = new Complex();
            var z2 = new Complex();

            z1.Real = 3D;
            z1.Imaginary = 4D;

            z2.Real = 2D;
            z2.Imaginary = -2D;

            Console.WriteLine("*** RoutingService with Message Filters ***\n");
            Console.WriteLine("Please hit any key to start: ");
            string command = Console.ReadLine();

            while (command != "exit")
            {
                ComplexNumberArithmetics(channel, z1, z2, msgChannel);

                Console.WriteLine("\nPlease hit any key to re-run OR enter 'exit' to exit.");
                command = Console.ReadLine();
            }

            ((IClientChannel)channel).Close();
        }

        static string f(Complex z)
        {
            return ($"({z.Real}, {z.Imaginary})");
        }

        static void ComplexNumberArithmetics(IComplexNumber channel, Complex z1, Complex z2, IMessenger messenger)
        {
            try
            {
                var builder = new StringBuilder();

                builder.AppendFormat("\n*** Complex Number Arithmetics ***\n\n");
                builder.AppendFormat("{0} + {1} = {2}\n", f(z1), f(z2), f(channel.Add(z1, z2)));
                builder.AppendFormat("{0} - {1} = {2}\n", f(z1), f(z2), f(channel.Subtract(z1, z2)));
                builder.AppendFormat("{0} * {1} = {2}\n", f(z1), f(z2), f(channel.Multiply(z1, z2)));
                builder.AppendFormat("{0} / {1} = {2}\n", f(z1), f(z2), f(channel.Divide(z1, z2)));
                builder.AppendFormat("Conjugate[{0}] = {1}\n", f(z1), f(channel.Conjugate(z1)));
                builder.AppendFormat("Conjugate[{0}] = {1}\n", f(z2), f(channel.Conjugate(z2)));
                builder.AppendFormat("Recipocal[{0}] = {1}\n", f(z1), f(channel.Recipocal(z1)));
                builder.AppendFormat("Recipocal[{0}] = {1}\n", f(z2), f(channel.Recipocal(z2)));
                builder.AppendFormat("Modulus[{0}] = {1}\n", f(z1), channel.Modulus(z1));
                builder.AppendFormat("Modulus[{0}] = {1}\n", f(z2), channel.Modulus(z2));
                builder.AppendFormat("Argument[{0}] = {1} Radians\n", f(z1), channel.Argument(z1));
                builder.AppendFormat("Argument[{0}] = {1} Radians\n", f(z2), channel.Argument(z2));

                var msg = builder.ToString();
                Console.WriteLine(msg);
                messenger.SendMessage(msg);
            }
            catch (Exception fx)
            {
                Console.WriteLine(fx.Message);
            }
        }
    }
}
