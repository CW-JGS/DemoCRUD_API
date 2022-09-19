
namespace api.contracts.exceptions;

public class SaltGenException: Exception
{
    public SaltGenException()
    {
        
    }

    public SaltGenException(string _msg) : base(_msg)
    {
        
    }

    public SaltGenException(string _msg, Exception _exceptionBase) : base(_msg, _exceptionBase)
    {
        
    }
    
}