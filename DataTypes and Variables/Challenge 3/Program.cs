namespace Challenge_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 255;
            Console.WriteLine(myByte);
            sbyte mySByte = 127;
            Console.WriteLine(mySByte);
            int myInt = 2147483547;
            Console.WriteLine(myInt);
            uint myUInt = 4294967295;
            Console.WriteLine(myUInt);
            short myShort = 32767;
            Console.WriteLine(myShort);
            ushort myUShort = 65535;
            Console.WriteLine(myUShort);
            long myLong = 9223372036854775807L;
            Console.WriteLine(myLong);
            ulong myULong = 18446744073709551615UL;
            Console.WriteLine(myULong);
            float myFloat = 3.14159f;
            Console.WriteLine(myFloat);
            double myDouble = 3.141592653589793;
            Console.WriteLine(myDouble);
            char myChar = 'J';
            Console.WriteLine(myChar);
            bool myBool = true;
            Console.WriteLine(myBool);
            string myString = "I control text";
            Console.WriteLine(myString);
            decimal myDecimal = 3.1415926535897932384626433833m;
            Console.WriteLine(myDecimal);


            string myString2 = "160599";
            int parsedInt = Int32.Parse(myString2);
            Console.WriteLine(parsedInt);

        }
    }
}