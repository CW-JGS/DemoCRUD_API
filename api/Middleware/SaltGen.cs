using System.Text;
using api.contracts.exceptions;

namespace api.Middleware;

public class SaltGen: RandomString
{
    private Random _random = new Random();
    public string Salt { get; set; }
    public SaltGen()
    {
        Salt = GenerateSalt();
    }

    public string NextSalt()
    {
        Salt = GenerateSalt();
        return Salt;
    }
    private string GenerateSalt()
    {
        var saltBuilder = new StringBuilder();
        int choice = 0;
        for (int i = 0; i <= 4; i++)
        {
            choice = _random.Next(1, 4);
            switch (choice)
            {
                case 1:
                    saltBuilder.Append(rndStr(4, 'M'));
                    break;
                case 2:
                    saltBuilder.Append(rndStr(4, 'L'));
                    break;
                case 3: 
                    saltBuilder.Append(rndStr(_size: 4, 'U'));
                    break;
            }    
        }
        return saltBuilder.ToString();
    }
}

public abstract class RandomString
{
    private Random _random = new Random();
    public string rndStr(int _size, char _type)
    {
        char offset = 'A';
        const int letterOffset = 26;
        var builder = new StringBuilder(_size);
        switch (_type)
        {
            case 'U':
                for (int i = 0; i < _size; i++)
                {
                    var @char = (char)_random.Next(offset, offset + letterOffset);
                    builder.Append(@char);
                }
                try
                {
                    return builder.ToString();
                }
                catch (SaltGenException err)
                {
                    Console.WriteLine(err);
                    throw;
                }
            case 'L':
                offset = 'a';
                for (int i = 0; i < _size; i++)
                {
                    var @char = (char)_random.Next(offset, offset + letterOffset);
                    builder.Append(@char);
                }
                try
                {
                    return builder.ToString().ToLower();
                }
                catch (SaltGenException err)
                {
                    Console.WriteLine(err);
                    throw;
                }
            case 'M':
                for (int i = 0; i < _size; i++)
                {
                    offset = offset == 'A' ? 'a' : 'A';
                    var @char = (char)_random.Next(offset, offset + letterOffset);
                    builder.Append(@char);
                }

                try
                {
                    return builder.ToString();
                }
                catch (SaltGenException err)
                {
                    Console.WriteLine(err);
                    throw;
                }
        }

        throw new SaltGenException("generation failed");
    }
}