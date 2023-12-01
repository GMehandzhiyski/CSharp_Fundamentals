namespace _603.ThePianist
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());
            List<Piece> pieces = new List<Piece>();

            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] argumets = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string pieceName = argumets[0];
                string composer = argumets[1];
                string key = argumets[2];

                Piece piece = new Piece(pieceName, composer, key);
                pieces.Add(piece);
            }

            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "Stop")
            {
                string[] commands = arguments
                    .Split("|", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = commands[0];
                string pieceName = commands[1];

                if (command == "Add")
                {
                    string composer = commands[2];
                    string key = commands[3];

                    bool isHaveThisPiece = CheckPieceToDB(pieces,pieceName);
                    if (isHaveThisPiece)
                    {
                        Console.WriteLine($"{pieceName} is already in the collection!");
                    }
                    else
                    {
                        AddNewPiece(pieces, pieceName, composer, key);
                        Console.WriteLine($"{pieceName} by {composer} in {key} added to the collection!");
                    }

                }
                else if (command == "Remove")
                {
                    bool isHaveThisPiece = CheckPieceToDB(pieces, pieceName);
                    if (isHaveThisPiece)
                    {
                        RemovePiece(pieces, pieceName);
                        Console.WriteLine($"Successfully removed {pieceName}!");
                    }
                    else 
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                    
                }
                else if (command == "ChangeKey")
                {
                    string newKey = commands[2];
                    bool isHaveThisPiece = CheckPieceToDB(pieces, pieceName);
                    if (isHaveThisPiece)
                    {
                        ChangeKey(pieces, pieceName, newKey);
                        Console.WriteLine($"Changed the key of {pieceName} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                   
                }
                else
                {
                    continue;
                }
            }

            PrintAllPiece(pieces);

        }

        private static void PrintAllPiece(List<Piece> pieces)
        {
            foreach (var currPiece in pieces)
            {
                Console.WriteLine($"{currPiece.PieceName} -> Composer: {currPiece.Composer}, Key: {currPiece.Key}");
            }
        }

        private static void ChangeKey(List<Piece> pieces, string pieceName, string newKey)
        {
            foreach (Piece currPiece in pieces)
            {
                if (currPiece.PieceName == pieceName)
                { 
                    currPiece.Key = newKey;
                }
            }
        }

        private static bool CheckPieceToDB(List<Piece> pieces, string pieceName)
        {
            bool isHaveThisPiece = false;
            Piece currPiece = pieces.FirstOrDefault(p => p.PieceName == pieceName);
            if (currPiece != null) 
            {
              return isHaveThisPiece = true;
            }
            return isHaveThisPiece;
        }

        private static void RemovePiece(List<Piece> pieces, string pieceName)
        {
            for (int i = 0; i < pieces.Count; i++)
            {
                if (pieces[i].PieceName == pieceName)
                {
                    pieces.Remove(pieces[i]);
                }
            }

        }

        public static void AddNewPiece(List<Piece> pieces, string pieceName, string composer, string key)
        {
            Piece piece = new Piece(pieceName, composer, key);
            pieces.Add(piece);
        }
    }
    public class Piece
    {
        public Piece(string pieceName, string composer, string key)
        {
            PieceName = pieceName;
            Composer = composer;
            Key = key;
        }

        public string PieceName { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }
    }

}