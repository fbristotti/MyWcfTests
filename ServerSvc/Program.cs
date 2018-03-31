using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServerSvc
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(ComplexNumberCalculator));
            var msgHost = new ServiceHost(typeof(MyMessenger));

            try
            {
                host.Open();
                msgHost.Open();
                Console.WriteLine("service started...");
                Console.ReadLine();
                host.Close();
                msgHost.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                host.Abort();
                msgHost.Abort();
            }

            Console.WriteLine("press [enter] to exit.");
            Console.ReadLine();
        }
    }

    [ServiceContract]
    public interface IMessenger
    {
        [OperationContract(IsOneWay = true)]
        void SendMessage(string message);
    }

    public class MyMessenger : IMessenger
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Client says {message}");
        }
    }

    [DataContract]
    public class Complex
    {
        [DataMember] public double Real;

        [DataMember] public double Imaginary;
    }

    [ServiceContract]
    public interface IComplexNumber
    {
        [OperationContract]
        Complex Add(Complex x, Complex y);

        [OperationContract]
        Complex Subtract(Complex x, Complex y);

        [OperationContract]
        Complex Multiply(Complex x, Complex y);

        [OperationContract]
        Complex Divide(Complex x, Complex y);

        [OperationContract]
        double Modulus(Complex x);

        [OperationContract]
        double Argument(Complex x);

        [OperationContract]
        Complex Conjugate(Complex x);

        [OperationContract]
        Complex Recipocal(Complex x);
    }

    public class ComplexNumberCalculator : IComplexNumber
    {
        public Complex Add(Complex x, Complex y)
        {
            Console.WriteLine("Invoked ComplexNumberCalculator Operation: Add");

            var z = new Complex();

            z.Real = x.Real + y.Real;
            z.Imaginary = x.Imaginary + y.Imaginary;

            return z;
        }

        public Complex Subtract(Complex x, Complex y)
        {
            Console.WriteLine("Invoked ComplexNumberCalculator Operation: Subtract");

            var z = new Complex();

            z.Real = x.Real - y.Real;
            z.Imaginary = x.Imaginary - y.Imaginary;

            return z;
        }

        public Complex Multiply(Complex x, Complex y)
        {
            Console.WriteLine("Invoked ComplexNumberCalculator Operation: Multiply");

            var z = new Complex();

            z.Real = x.Real * y.Real - x.Imaginary * y.Imaginary;
            z.Imaginary = x.Real * y.Imaginary + x.Imaginary * y.Real;

            return z;
        }

        public Complex Divide(Complex x, Complex y)
        {
            Console.WriteLine("Invoked ComplexNumberCalculator Operation: Divide");

            var z = new Complex();

            var modulusY = this.Modulus(y);

            z.Real = (x.Real * y.Real + x.Imaginary * y.Imaginary) / (modulusY * modulusY);
            z.Imaginary = (x.Imaginary * y.Real - x.Real * y.Imaginary) / (modulusY * modulusY);

            return z;
        }

        public double Modulus(Complex x)
        {
            Console.WriteLine("Invoked ComplexNumberCalculator Operation: Modulus");

            var modX = Math.Sqrt(x.Real * x.Real + x.Imaginary * x.Imaginary);

            return modX;
        }

        public Complex Conjugate(Complex x)
        {
            Console.WriteLine("Invoked ComplexNumberCalculator Operation: Conjugate");

            var z = new Complex();

            z.Real = x.Real;
            z.Imaginary = -1 * x.Imaginary;

            return z;
        }

        public double Argument(Complex x)
        {
            Console.WriteLine("Invoked ComplexNumberCalculator Operation: Argument");

            var argumentX = Math.Atan(x.Imaginary / x.Real);

            return argumentX;
        }

        public Complex Recipocal(Complex x)
        {
            Console.WriteLine("Invoked ComplexNumberCalculator Operation: Recipocal");

            var z = new Complex();

            var modulusX = this.Modulus(x);
            var conjugateX = this.Conjugate(x);

            z.Real = conjugateX.Real / (modulusX * modulusX);
            z.Imaginary = conjugateX.Imaginary / (modulusX * modulusX);

            return z;
        }
    }
}
