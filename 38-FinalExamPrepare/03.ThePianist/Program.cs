namespace _03.ThePianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Piece> piecesList = new List<Piece>();

            int numberOfPieces = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] inputString = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string piece = inputString[0];
                string composer = inputString[1];
                string key = inputString[2];
                Piece pieceIn = new Piece(piece, composer, key);
                piecesList.Add(pieceIn);

            }

            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "Stop")
            {
                string[] command = arguments
                    .Split("|", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0] == "Add")
                {
                    string newPiece = command[1];
                  
                    bool isHaveThisPiece = CheckFotCurrPiece(piecesList, newPiece);
                    if (isHaveThisPiece)
                    {
                        string piece = newPiece;
                        string composer = command[2];
                        string key = command[3];
                        Piece pieceIn = new Piece(piece, composer, key);
                        piecesList.Add(pieceIn);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{newPiece} is already in the collection!");
                    }
                }
                else if (command[0] == "Remove")
                {
                    string newPiece = command[1];

                    bool isHaveThisPiece = CheckFotCurrPiece(piecesList, newPiece);
                    if (!isHaveThisPiece)
                    {
                        int indexOfFoundPiece = CheckForPieceIndex(piecesList, newPiece);
                        piecesList.RemoveAt(indexOfFoundPiece);
                        Console.WriteLine($"Successfully removed {newPiece}!");
                    }
                    else 
                    {
                        Console.WriteLine($"Invalid operation! {newPiece} does not exist in the collection.");
                    }
                }
                else if (command[0] == "ChangeKey")
                {
                    string newPiece = command[1];
                    string newKey = command[2];

                    bool isHaveThisPiece = CheckFotCurrPiece(piecesList, newPiece);
                    if (!isHaveThisPiece)
                    {
                        int indexOfFoundPiece = CheckForPieceIndex(piecesList, newPiece);
                        piecesList[indexOfFoundPiece].Key = newKey;
                        Console.WriteLine($"Changed the key of {newPiece} to {newKey}!");
                    }
                    else 
                    {
                        Console.WriteLine($"Invalid operation! {newPiece} does not exist in the collection.");
                    }

                }
                else
                {
                    continue;
                }



            }

            foreach (var piece in piecesList)
            {
                Console.WriteLine($"{piece.PieceCtor} -> Composer: {piece.Composer}, Key: {piece.Key}");
            }
           

        }

        private static int CheckForPieceIndex(List<Piece> piecesList, string newPiece)
        {   
            int currPieceIndex = 0;
            for (int i = 0; i < piecesList.Count; i++)
            {
                if (piecesList[i].PieceCtor == newPiece)
                {
                    currPieceIndex = i;
                    break;
                }
            }
            return currPieceIndex;
        }

        private static bool CheckFotCurrPiece(List<Piece> piecesList, string newPiece)
        {
            bool isHaveThisPiece = false;
            Piece currPiece = piecesList.FirstOrDefault((p => p.PieceCtor == newPiece));
            if (currPiece != null)
            {
                isHaveThisPiece = false;
            }
            else
            {
                isHaveThisPiece = true;
            }
            return isHaveThisPiece;
        }
    }
    public class Piece
    {
        public Piece(string piece, string composer, string key)
        {
            PieceCtor = piece;
            Composer = composer;
            Key = key;
        }
        public string PieceCtor { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }

    }
}