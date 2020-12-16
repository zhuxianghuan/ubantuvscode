using System;
using System.Threading;
public delegate void haha(int value);
namespace shijian
{
    class Program
    {
        public event haha myevent;
        public void  cd()
        {

            if (myevent!=null)
            {
                myevent(20);
            }

        }
             public void  fangfa(int value)
            {

                System.Console.WriteLine("nihao a zhuxianghuan!");

            }
        static void Main(string[] args)
        {
            Program aa=new Program();
            aa.myevent+=new haha(aa.fangfa);
            while (true)
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(1000);
                    System.Console.WriteLine(i);
                    if (i==6)
                    {
                         aa.cd();
                    }
                }
                System.Console.WriteLine("");  

            }
           

        }
    }
}
