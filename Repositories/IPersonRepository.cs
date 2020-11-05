namespace Portfolio.Models
{
    /// <summary>
    /// Gets the user by ID
    /// </summary>
    public interface IPersonRepository
    {
        Person GetPerson(int ID);
    }
}
