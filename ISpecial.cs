namespace dreamTeam
{
    public class DreamTeam
    {
        public string firstName { get; set;}
        public string lastName { get; set;}
        public string FullName => $"{firstName} {lastName}";

        public string Specialty { get; set; }
        public string Work()
        {
            return $"{FullName} is performing {Specialty}";
        }
    }
}