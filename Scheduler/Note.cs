namespace Scheduler
{
    // Class Contents
    // This class is meant to stimulate a basic note and or 
    // text file. These Notes must inclide a Title,
    // Message. These notes suppoed to provide the User a 
    // convient way to store and access information in a
    // similar way to a real note or txt file. 
    public class Note
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }

        public Note(string _Name, string _Content, string _Date) 
        {
            Name   = _Name;
            Date   = _Date;
            Content  = _Content;
        }
    }
}
