﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2122_4E_INF_Prof_ProvaGestioneArticoli
{
    class Articolo
    {
        // TODO: (8) aggiungere attributi privati di Articolo
        // ...
        public int Codice { get; private set; }
        public string Descdrizione { get; private set; }
        public string UnitaMisura { get; private set; }
        public double Prezzo { get; private set; }

        // TODO: (9) aggiungere property di sola lettura dei dati necessari all'esterno di Articolo
        // ...
        public int Codice
        {
            get { codice; }
        }
        public Articolo(int codice, string descrizione, string unitaMisura, double prezzo)
        {
            // TODO: (10) impostazione costruttore classe Articolo come utilizzato da frmMain
            // ...
        }

        public string Visualizzati()
        {
            return $"{descrizione} {unitaMisura} {prezzo} ({codice})";
        }
    }
}
