using Albuquerque.Core.Enums;

namespace Albuquerque.Core.Helpers
{
    public class ServiceResult<T>
    {
        public string Message { get; private set; }
        public OperationResultCode Code { get; private set; }
        public T Value { get; private set; }

        public ServiceResult(OperationResultCode code, string message = "", T value = default)
        {
            Message = message;
            Code = code;
            Value = value;
        }

        public bool IsError => 
            Code != OperationResultCode.Ok;
    }
}