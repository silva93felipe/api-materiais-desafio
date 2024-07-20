namespace ApiMateriais.Dto
{
    public class ResponseDto {
        public string Message {get;set;} = string.Empty;
        public string Status {get;set;} = string.Empty;
        public object Data {get;set;} = new List<object>();
        public ResponseDto(string message, string status)
        {
            Message = message;
            Status = status;
        }

        public ResponseDto(string message, string status, object data)
        {
            Message = message;
            Status = status;
            Data = data;
        }
    }
}