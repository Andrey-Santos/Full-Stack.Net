using System.Reflection.Metadata;
using System.Text.Json.Serialization;

abstract class Response<TData>
{
    [JsonConstructor]
    public Response()
        => _code = Configuration.DefaultStatusCode;

    public Response(TData? data, int code = Configuration.DefaultStatusCode, string? message = null)
    {
        Data = data;
        _code = code;
        Message = message;
    }
    private int _code = Configuration.DefaultStatusCode;

    public TData? Data { get; set; }
    public string? Message { get; set; }

    [JsonIgnore]
    public Boolean IsSuccess7 => _code is >= Configuration.DefaultStatusCode and <= 299;
}