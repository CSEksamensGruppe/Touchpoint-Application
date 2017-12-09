﻿using System;
namespace TouchpointApp.Model
{
    public class Kursist
    {
        // Instance Fields

        private string _navn;
        private string _email;
        private string _by;
        private string _land;
        private string _adresse;
        private string _tlf;

        // Properties

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string EMail
        {
            get { return _email; }
            set { _email = value; }
        }

        public string By
        {
            get { return _by; }
            set { _by = value; }
        }

        public string Land
        {
            get { return _land; }
            set { _land = value; }
        }
        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }
        public string Tlf
        {
            get { return _tlf; }
            set { _tlf = value; }
        }

        // Constructor

        public Kursist(string navn, string email, string by, string land, string adresse, string tlf)
        {
            if(String.IsNullOrEmpty(navn) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(by) || String.IsNullOrEmpty(land) || String.IsNullOrEmpty(adresse) || String.IsNullOrEmpty(tlf))
            {
                throw new ArgumentException("Personlig information mangler");
            }

            CheckForTal(navn,by,land);
            CheckTlfLængde(tlf);
            
            _navn = navn ;
            _email = email;
            _by = by;
            _land = land;
            _adresse = adresse;
            _tlf = tlf;
        }

        public void CheckForTal(string navn, string by, string land)
        {
            int value;


            if (int.TryParse(navn, out value))

            {
                throw new ArgumentException("Der kan ikke indtastes tal i navn");
            }

            if(int.TryParse(by, out value))
            {
                throw new ArgumentException("Der kan ikke indtastes tal i by");
            }

            if(int.TryParse(land,out value))
            {
                throw new ArgumentException("Der kan ikke indtastes tal i land");
            }

        }

        public void CheckTlfLængde(string tlf)
        {

            if (tlf.Length < 8 || tlf.Length > 8)
            {
                throw new ArgumentException("Invalid telefonnummer");
            }

        }
        public override string ToString()
        {
            return $"{_navn}";
        }
    }
}