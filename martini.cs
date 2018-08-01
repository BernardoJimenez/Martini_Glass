using System;
using System.Text;

namespace ConsoleApp1{
    class Martini{

        private string mBase = "=";
        private string mNeck = "|";
        private string mBowl = "0";

        private void constructBase(int size) {
            for (int b = 0; b < ((size - 1) * 2); b++) {
                mBase += "=";
            }
            Console.WriteLine(mBase);
        }

        private void constructNeck(int size) {
            String spaces = " ";

            for (int s = 0; s < (size - 2); s++) {
                spaces += " ";
            }

            mNeck = spaces + mNeck;

            for (int n = 0; n < size; n++) {
                Console.WriteLine(mNeck);
            }
        }

        private void constructBowl(int size) {
            for (int s = 0; s < ((size*2) - 2); s++) {
                mBowl += "0";
            }

            int startOfZeros = 0;
            int endOfZeroes = (mBowl.Length - 1);
            Console.WriteLine(mBowl);
            StringBuilder sb = new StringBuilder(mBowl);


            while (startOfZeros != endOfZeroes) {
                sb[startOfZeros] = ' ';
                sb[endOfZeroes] = ' ';
                Console.WriteLine(sb.ToString());
                startOfZeros++;
                endOfZeroes--;
            }
        }

        public void constructMartini(int size) {
            if (size < 1){
                Console.WriteLine("Liqour licesne revoked!");
            } else if (size == 1){
                Console.WriteLine(mBowl);
                Console.WriteLine(mNeck);
                Console.WriteLine(mBase);
            } else {
                constructBowl(size);
                constructNeck(size);
                constructBase(size);
            }
            // set back to original
            mBowl = "0";
            mNeck = "|";
            mBase = "=";
        }


        static void Main(string[] args){
            Martini liqour = new Martini();

            liqour.constructMartini(4);
            Console.WriteLine();
            liqour.constructMartini(5);
        }
    }
}