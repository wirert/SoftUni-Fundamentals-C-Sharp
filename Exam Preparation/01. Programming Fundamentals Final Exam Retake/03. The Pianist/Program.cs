using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPieces = int.Parse(Console.ReadLine());

            var piecesList = new List<Piece>();

            CreateTheCollectionOfPieces(numPieces, piecesList);

            string command = null;

            while ((command = Console.ReadLine()) != "Stop")
            {
                var tokens = command.Split('|');

                switch (tokens[0])
                {
                    case "Add":
                        AddPieceToTheCollection(tokens, piecesList);
                        break;
                    case "Remove":
                        RemovePieceFromCollection(tokens, piecesList);
                        break;
                    case "ChangeKey":
                        ChangeKeyOfPieceFromCollection(tokens, piecesList);
                        break;
                }
            }

            foreach (var piece in piecesList)
            {
                Console.WriteLine($"{piece.PieceName} -> Composer: {piece.Composer}, Key: {piece.Key}");
            }
        }

        private static void CreateTheCollectionOfPieces(int numPieces, List<Piece> piecesList)
        {
            for (int i = 0; i < numPieces; i++)
            {
                var piece = Console.ReadLine().Split('|');

                string pieceName = piece[0];
                string composer = piece[1];
                string pieceKey = piece[2];

                piecesList.Add(new Piece(pieceName, composer, pieceKey));
            }
        }

        private static void AddPieceToTheCollection(string[] tokens, List<Piece> piecesList)
        {
            string pieceName = tokens[1];
            string composer = tokens[2];
            string pieceKey = tokens[3];

            if (piecesList.Exists(x => x.PieceName == pieceName))
            {
                Console.WriteLine($"{pieceName} is already in the collection!");
                return;
            }

            var pieceToAdd = new Piece(pieceName, composer, pieceKey);

            piecesList.Add(pieceToAdd);
            Console.WriteLine($"{pieceToAdd.PieceName} by {pieceToAdd.Composer} in {pieceToAdd.Key} added to the collection!");
        }

        private static void RemovePieceFromCollection(string[] tokens, List<Piece> piecesList)
        {
            string pieceToRemove = tokens[1];

            if (!piecesList.Exists(x => x.PieceName == pieceToRemove))
            {
                Console.WriteLine($"Invalid operation! {pieceToRemove} does not exist in the collection.");
                return;
            }

            piecesList.Remove(piecesList.First(x => x.PieceName == pieceToRemove));

            Console.WriteLine($"Successfully removed {pieceToRemove}!");
        }

        private static void ChangeKeyOfPieceFromCollection(string[] tokens, List<Piece> piecesList)
        {
            string pieceToChange = tokens[1];
            string keyToChange = tokens[2];

            if (!piecesList.Exists(x => x.PieceName == pieceToChange))
            {
                Console.WriteLine($"Invalid operation! {pieceToChange} does not exist in the collection.");
                return;
            }

            piecesList.First(x => x.PieceName == pieceToChange).Key = keyToChange;

            Console.WriteLine($"Changed the key of {pieceToChange} to {keyToChange}!");
        }
    }

    class Piece
    {
        public Piece(string pieceName, string composer, string key)
        {
            this.PieceName = pieceName;
            this.Composer = composer;
            this.Key = key;
        }
        public string Composer { get; set; }
        public string PieceName { get; set; }
        public string Key { get; set; }
    }
}
