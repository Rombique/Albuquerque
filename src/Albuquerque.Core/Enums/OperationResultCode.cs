using System.ComponentModel;

namespace Albuquerque.Core.Enums
{
    public enum OperationResultCode
    {
        [Description("Ок")]
        Ok,

        [Description("Не найден")]
        NotFound,

        [Description("Ошибка логики")]
        UnprocessableEntity
    }
}