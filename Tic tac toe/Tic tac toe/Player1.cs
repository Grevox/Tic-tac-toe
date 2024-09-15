using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tac_toe
{

    public class Pl1
    {
        public char position1 = '.';
        public char position2 = '.';
        public char position3 = '.';
        public char position4 = '.';
        public char position5 = '.';
        public char position6 = '.';
        public char position7 = '.';
        public char position8 = '.';
        public char position9 = '.';
        public const String cheers1 = "player1 wins, congratulations!";
        public const String cheers2 = "player2 wins, unexpected!";

        public void Grid()
        {
            Console.WriteLine("   ");
            Console.Write(position1 + "     "); Console.Write(position2 + "     "); Console.WriteLine(position3);
            Console.Write(position4 + "     "); Console.Write(position5 + "     "); Console.WriteLine(position6);
            Console.Write(position7 + "     "); Console.Write(position8 + "     "); Console.WriteLine(position9);


        }
        public void yPlacer() 
        {
            
                String secondChoice = Console.ReadLine();
                int convertedchoice = Convert.ToInt32(secondChoice);
                if (convertedchoice == 1)
                {
                    position1 = 'O';


                }
                else if (convertedchoice == 2)
                {
                    position2 = 'O';



                }
                else if (convertedchoice == 3)
                {
                    position3 = 'O';



                }
                else if (convertedchoice == 4)
                {
                    position4 = 'O';


                }
                else if (convertedchoice == 5)
                {
                    position5 = 'O';


                }
                else if (convertedchoice == 6)
                {
                    position6 = 'O';


                }
                else if (convertedchoice == 7)
                {
                    position7 = 'O';


                }
                else if (convertedchoice == 8)
                {
                    position8 = 'O';


                }
                else if (convertedchoice == 9)
                {
                    position9 = 'O';


                }


            Grid();
            }

        public void xplacer()    
        {
            String firstChoice = Console.ReadLine();
            int convertedchoice = Convert.ToInt32(firstChoice);
            if (convertedchoice == 1)
            {
                position1 = 'X';


            }
            else if (convertedchoice == 2)
            {
                position2 = 'X';



            }
            else if (convertedchoice == 3)
            {
                position3 = 'X';



            }
            else if (convertedchoice == 4)
            {
                position4 = 'X';


            }
            else if (convertedchoice == 5)
            {
                position5 = 'X';


            }
            else if (convertedchoice == 6)
            {
                position6 = 'X';


            }
            else if (convertedchoice == 7)
            {
                position7 = 'X';


            }
            else if (convertedchoice == 8)
            {
                position8 = 'X';


            }
            else if (convertedchoice == 9)
            {
                position9 = 'X';


            }
            Grid();
            



        }
        public void WinCheckP1()
        {
            if (position1 == 'X' && position2 == 'X' && position3 == 'X')
            {
                Console.WriteLine(cheers1);
                Console.ReadLine();
                WonNo();
            }
            else if(position1 == 'X' && position5 == 'X' && position9 == 'X') 
            {

                Console.WriteLine(cheers1);
                Console.ReadLine();
                WonNo();

            }
            else if (position3 == 'X' && position5 == 'X' && position7 == 'X')
            {

                Console.WriteLine(cheers1);
                Console.ReadLine();
                WonNo();

            }
            else if (position1 == 'X' && position4 == 'X' && position7 == 'X')
            {

                Console.WriteLine(cheers1);
                Console.ReadLine();
                WonNo();

            }
            else if (position2 == 'X' && position5 == 'X' && position8 == 'X')
            {

                Console.WriteLine(cheers1);
                Console.ReadLine();
                WonNo();

            }
            else if (position7 == 'X' && position8 == 'X' && position9 == 'X')
            {

                Console.WriteLine(cheers1);
                Console.ReadLine();
                WonNo();
            }
            else if (position4 == 'X' && position5 == 'X' && position6 == 'X')
            {

                Console.WriteLine(cheers1);
                Console.ReadLine();
                WonNo();

            }
            else if (position3 == 'X' && position6 == 'X' && position9 == 'X')
            {

                Console.WriteLine(cheers1);
                Console.ReadLine();
                WonNo();

            }
            


        }
        public void WinCheckP2()
        {
            if (position1 == 'O' && position2 == 'O' && position3 == 'O')
            {
                Console.WriteLine(cheers2);
                Console.ReadLine();
                WonNo();
            }
            else if (position1 == 'O' && position5 == 'O' && position9 == 'O')
            {

                Console.WriteLine(cheers2);
                Console.ReadLine();
                WonNo();

            }
            else if (position3 == 'O' && position5 == 'O' && position7 == 'O')
            {

                Console.WriteLine(cheers2);
                Console.ReadLine();
                WonNo();

            }
            else if (position1 == 'O' && position4 == 'O' && position7 == 'O')
            {

                Console.WriteLine(cheers2);
                Console.ReadLine();
                WonNo();

            }
            else if (position2 == 'O' && position5 == 'O' && position8 == 'O')
            {

                Console.WriteLine(cheers2);
                Console.ReadLine();
                WonNo();

            }
            else if (position7 == 'O' && position8 == 'O' && position9 == 'O')
            {

                Console.WriteLine(cheers2);
                Console.ReadLine();
                WonNo();

            }
            else if (position4 == 'O' && position5 == 'O' && position6 == 'O')
            {

                Console.WriteLine(cheers2);
                Console.ReadLine();
                WonNo();

            }
            else if (position3 == 'O' && position6 == 'O' && position9 == 'O')
            {

                Console.WriteLine(cheers2);
                Console.ReadLine();
                WonNo();
                


            }
            


        }
       public void P1turn()
        {
            Console.WriteLine("P1 turn");
            xplacer();
            WinCheckP1();
        }
        public void P2turn() 
        {
        Console.WriteLine("P2 Turn");
            yPlacer();
            WinCheckP2();
        
        
        }
        public void CheckX()
        {
            if (position1 == 'X') 
            {
                    
            }
        
        
        
        }
        public void WonNo()
        {
            Console.WriteLine("\n\n\n[press enter to continue]");
            Console.ReadLine();
            TicTacToe.callmeplease();
        }



        public Pl1()
        {
            
            Grid();
            
            Console.WriteLine("P1, GET READY!");
            Console.WriteLine("choose a position between 1 to 9");
            P1turn();
            P2turn();
            P1turn();
            P2turn();
            P1turn();
            P2turn();
            P1turn();
            P2turn();
            P1turn();
            Console.WriteLine("nobody won");
            WonNo();
            
            
            






        }
       






        }
    }

