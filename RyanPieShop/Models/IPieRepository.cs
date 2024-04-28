namespace RyanPieShop.Models
{
    public interface IPieRepository
    {
        //declare properties names "AllPies" of type IEnumerable<Pie> within interface
        //It has only a getter(no setter) and returns a collection of 'Pie' objects
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }

        //This line declares a method named GetPieById that takes an integer id as a parameter and
        //returns a Pie object.
        //The ? after Pie indicates that the method can return null
        Pie? GetPieById(int pieId);
    }
}
