//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aufgabe3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bahnsteigdaten
    {
        public int Bahnhofsnummer { get; set; }
        public string Bahnsteig { get; set; }
        public string Gleisnummer { get; set; }
        public string oertliche_Bezeichnung { get; set; }
        public Nullable<int> Nettobaulaenge_m { get; set; }
        public Nullable<int> Hoehe_Bahnsteigkante_cm { get; set; }
    
        public virtual Bahnhoefe Bahnhoefe { get; set; }
    }
}
