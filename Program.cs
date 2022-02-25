using System;
using Abstração_de_um_Jogo_RPG.src.Entities;

namespace dotnet_____poo
{
        class Program
        {
                static void  Main(string[] args)
                {
                    Hero ashe =  new Hero("Ashe", 30, "Arqueira");
                    Wizard wizard =  new Wizard("Fiora", 40, "Lutadora");

                   Console.WriteLine(ashe.Attack());
                   Console.WriteLine(wizard.Attack());
                }            
        }
}