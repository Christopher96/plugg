using System;

namespace moment3 
{
    class CD
    {   
        // Definera variabler och properties för dem
        private string _artist;
        public string artist {
            get { return _artist; }   
            set { _artist = value; }
        }
        private string _title;
        public string title {
            get { return _title; }   
            set { _title = value; }
        }
        private string _genre;
        public string genre {
            get { return _genre; }   
            set { _genre = value; }
        }
        private int _year;
        public int year {
            get { return _year; }   
            set { _year = value; }
        }
        private string _company;
        public string company {
            get { return _company; }   
            set { _company = value; }
        }
        private int _songs;
        public int songs {
            get { return Math.Max(0, _songs); }   
            set { _songs = value; }
        }
        private double _length;
        public double length {
            get { return Math.Max(0, _length); }   
            set { _length = value; }
        }
        
        // Konstruktor utan parametrar
        public CD() {
        }

        // Konstruktor med 2 parametrar
        public CD(string artist, string title) {
            this.artist = artist;
            this.title = title;
        }

        // Konstruktor med alla parametrar
        public CD(string artist, string title, string genre, int year, string company, int songs, double length) {
            this.artist = artist;
            this.title = title;
            this.genre = genre;
            this.year = year;
            this.company = company;
            this.songs = songs;
            this.length = length;
        }

        // Utmatning för kort beskrivning av CD
        public void PrintBrief() {
            string time = convertTime(this.length);
            Console.WriteLine("{0}, {1} ~ {2}.", this.artist, this.title, time);
        }

        // Utmatning för lång beskrivning av CD
        public void PrintFull() {
            string time = convertTime(this.length);
            Console.WriteLine("{0}, {1} ({2}) - {3}. {4} Songs ~ {5}. [{6}]", this.artist, this.title, this.year, this.company, this.songs, time, this.genre);
        }

        // Metod för att konvertera minuter till timmar
        public string convertTime(double length) {
            if( length > 60 )  {
                double hours = Math.Floor(length/60);
                string hoursTxt = hours.ToString();

                double minutes = length % 60;
                string minutesTxt = minutes.ToString();
                if( minutes < 10 ) minutesTxt = "0" + minutes;

                return hoursTxt + ":" + minutesTxt + " h";
            } else {
                return length + " min";
            }
        }
    }
}