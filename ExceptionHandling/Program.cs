// See https://aka.ms/new-console-template for more information

Math math = new Math();
Console.WriteLine(math.Divide(20, 0));



class Math
{
    public int Add(int sayi1, int sayi2) {

        return sayi1 + sayi2;
    }

    public int Divide(int sayi1, int sayi2)
    {
        try
        {
            return sayi1 / sayi2;
        }
        catch (DivideByZeroException)
        {

            Console.WriteLine("Bir hata oluştu.");
            //return 0;
            throw new DivideByZeroException("Payda 0 olamaz");
        }
        catch(DllNotFoundException){

            Console.WriteLine("Bir hata oluştu.");
            //return 0;
            throw new DivideByZeroException("");

        }
        //Öngöremediğimiz hata
        catch (Exception exception)
        {

            Console.WriteLine("Öngöremediğimiz bir hata oluştu");
            //return 0;
            Console.WriteLine(exception.Message);
            throw;
        }

        //opsiyonel blok

        finally{
            Console.WriteLine("Finally çalıştı")

        }

    }
}