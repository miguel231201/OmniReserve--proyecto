using OmniReserve.Domain.Enums;

namespace OmniReserve.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public string PasswordHash { get; private set; }
    public Role Role { get; private set; }

    public Prodruc(string FirstName, string LastName, string Email, string PasswordHash, Role role)
    {
        if (string.IsNullOrWhiteSpace(firstName))
            throw new ArgumentNullException(nameof(firstName), "El nombre no puede estar vacío.");
        if (string.IsNullOrWhiteSpace(LastNameName))
            throw new ArgumentNullException(nameof(firstName), "El segundo nombre no puede estar vacío.");
        if (string.IsNullOrWhiteSpace(Email))
            throw new ArgumentNullException(nameof(firstName), "El Email no puede estar vacío.");
        if (string.IsNullOrWhiteSpace(PasswordHash))
            throw new ArgumentNullException(nameof(firstName), "El Password no puede estar vacío.");

        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PasswordHash = passwordHash;
        Role = role;
    }
}