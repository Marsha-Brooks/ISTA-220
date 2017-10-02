using System;

namespace MilitaryUnit
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Tour of the Maint Company");
            Maint myMaint = new Maint();
            myMaint.CmdMaint();
            myMaint.Motorpool();
            myMaint.Mission();
            



            Console.WriteLine("\nTour of the Construction Company");
            Construction myConstruction = new Construction();
            myConstruction.HorizVert();
            myConstruction.ConstEquip();
            myConstruction.Mission();


            Console.WriteLine("\nTour of the Signal Company");
            Signal mySignal = new Signal();
            mySignal.AppendixH();
            mySignal.CommoShop();
            mySignal.Mission();
        }
    
        static void Main()
                {
                    try
                    {
                        doWork();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception: {0}", ex.Message);
                    }
                }
            }
        }
    

