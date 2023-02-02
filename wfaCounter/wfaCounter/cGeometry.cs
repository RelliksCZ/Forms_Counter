using System;
using System.Collections.Generic;
using System.Text;

namespace wfaCounter
{
    public class cGeometry
    {
        public struct Ctverec
        {
            private double _strana_a;
            private double _obvod;
            private double _obsah;

            public double Polomer_KO;
            public double Polomer_KV;
            public double Obvod_KO;
            public double Obvod_KV;

            public double Strana_a
            {
                get { return _strana_a; }
                set { _strana_a = value; }
            }

            public double Obvod
            {
                get { return _obvod; }
            }

            public double Obsah
            {
                get { return _obsah; }
            }

            public Ctverec(double a)
            {
                this._strana_a = a;
                this._obvod = 0;
                this._obsah = 0;
                this.Polomer_KO = 0;
                this.Polomer_KV = 0;
                this.Obvod_KO = 0;
                this.Obvod_KV = 0;
            }

            public void ZmenRozmery(double a)
            {
                this._strana_a = a;
               }
                        
            public void SpocitejOO()
            {
                //vypocet obvodu
                double vysledek = 0;
                vysledek = 4 * this._strana_a;
                this._obvod = vysledek;

                //vypocet obsahu
                vysledek = Math.Pow(this._strana_a, 2);
                this._obsah = vysledek;

            }
            public double VratObvod()
            {
                double vysledek = 0;
                vysledek  = 4 * this._strana_a;
                this._obvod = vysledek;
                return vysledek; 

            }
            public double VratObsah()
            {
                double vysledek = 0;
                vysledek = Math.Pow (this._strana_a,2);
                this._obsah = vysledek;
                return vysledek;
            }
        }
        public struct Obdelnik
        {
            private double _strana_a;
            private double _strana_b;
            private double _obvod;
            private double _obsah;
            public double Polomer_KO;
            public double Polomer_KV;
            public double Obvod_KO;
            public double Obvod_KV;

            public double Strana_a
            {
                get { return _strana_a; }
                set { _strana_a = value; }
            }
            public double Strana_b
            {
                get { return _strana_b; }
                set { _strana_b = value; }
            }
            public double Obvod
            {
                get { return _obvod; }
            }

            public double Obsah
            {
                get { return _obsah; }
            }

            public Obdelnik(double a, double b)
            {
                this._strana_a = a;
                this._strana_b = b;
                this._obvod = 0;
                this._obsah = 0;
                this.Polomer_KO = 0;
                this.Polomer_KV = 0;
                this.Obvod_KO = 0;
                this.Obvod_KV = 0;
            }
            public void SpocitejOO()
            {
                //vypocet obvodu
                double vysledek = 0;
                vysledek = 2 * (this._strana_a + this._strana_b);
                this._obvod = vysledek;

                //vypocet obsahu
                vysledek = this._strana_a * this._strana_b;
                this._obsah = vysledek;

            }
            public void ZmenRozmery(double a, double b)
            {
                this._strana_a = a;
                this._strana_b = b;
            }
            public double VratObvod()
            {
                double vysledek = 0;
                vysledek = 2 * (this._strana_a + this._strana_b);
                this._obvod = vysledek;
                return vysledek;

            }
            public double VratObsah()
            {
                double vysledek = 0;
                vysledek = this._strana_a * this._strana_b;
                this._obsah = vysledek;
                return vysledek;
            }
        }

        public struct Trojuhelnik
        {
            private double _strana_a;
            private double _strana_b;
            private double _strana_c;
            private double _obvod;
            private double _obsah;
            public double Polomer_KO;
            public double Polomer_KV;
            public double Obvod_KO;
            public double Obvod_KV;

            public double Strana_a
            {
                get { return _strana_a; }
                set { _strana_a = value; }
            }
            public double Strana_b
            {
                get { return _strana_b; }
                set { _strana_b = value; }
            }
            public double Strana_c
            {
                get { return _strana_c; }
                set { _strana_c = value; }
            }

            public double Obvod
            {
                get { return _obvod; }
            }

            public double Obsah
            {
                get { return _obsah; }
            }
            public Trojuhelnik(double a, double b, double c)
            {
                this._strana_a = a;
                this._strana_b = b;
                this._strana_c = c;
                this._obvod = 0;
                this._obsah = 0;
                this.Polomer_KO = 0;
                this.Polomer_KV = 0;
                this.Obvod_KO = 0;
                this.Obvod_KV= 0;

                NastavRozmery_SpocitejObvodObsah(a, b, c); 

            }
            public void SpocitejOO()
            {
                //vypocet obvodu
                double vysledek = 0;
                vysledek = this._strana_a + this._strana_b + this._strana_c;
                this._obvod = vysledek;

                //vypocet obsahu
                double male_s = 0;
                male_s = (this._strana_a + this._strana_b + this._strana_c) / 2;
                vysledek = Math.Sqrt(male_s * (male_s - this._strana_a) * (male_s - this._strana_b) * (male_s - this._strana_c));
                this._obsah = vysledek;

            }
            public void NastavRozmery_SpocitejObvodObsah(double a, double b, double c) //SetDim_Solve
            {
                this._strana_a = a;
                this._strana_b = b;
                this._strana_c = c;

                this._obvod = this._strana_a + this._strana_b + this._strana_c;

                double male_s = 0;
                male_s = (this._strana_a + this._strana_b + this._strana_c) / 2;
                this._obsah = Math.Sqrt(male_s * (male_s - this._strana_a) * (male_s - this._strana_b) * (male_s - this._strana_c));

            }
            
        }
    }
}
