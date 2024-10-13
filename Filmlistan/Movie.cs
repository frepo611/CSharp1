namespace Filmlistan;
    public class Movie
    {
        public string Name { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int LengthInMinutes { get; set; }
        public bool SuitableForChildren { get; set; }
        public string[] Stars { get; set; }
    public override string ToString()
    {
        return $"{Name} är en film som regisserats av {Director} med premiär {ReleaseDate} och är {LengthInMinutes} minuter.\nSkådespelarna i filmen är {string.Join(",",Stars)}. Den är {(SuitableForChildren? "" : "inte")} lämplig för barn.";
    }
    }

