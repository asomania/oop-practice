using System;

class Model {
    public string ModelName {get; set;}
    public string ModelToken {get; }

    public Model(){
        Console.WriteLine("Model Need Apikey...");
    }
    
    public Model(string token){
        ModelToken = token;
    }

    public virtual void modelParamCount(){
        Console.WriteLine("This is Base LLM Model");
    }
}
class GeminiModel : Model{
    public GeminiModel(string apiKey): base(apiKey){
        ModelName = "Gemini";
        Console.WriteLine("Gemini Model Worked" + ModelToken);
    }
    public override void modelParamCount(){
        Console.WriteLine("Gemini Model Has 1 Billion Params");
    }
}
class OpenApiModel : Model{
    public OpenApiModel(string apiKey): base(apiKey){
        ModelName = "Open Ai";
        Console.WriteLine("OpenApi model Worked" + ModelToken);
    }
     public override void modelParamCount(){
        Console.WriteLine("OpenApi Model Has 2 Billion Params");
    }
}
class Program {
    public static void Main(){
        Model modelObj = new Model();
        Model geminiModelObj = new GeminiModel("12312WDEWFDEW");
        geminiModelObj.modelParamCount();
        Console.WriteLine(geminiModelObj.ModelName);
        Model openApiModelObj = new OpenApiModel("SDDWDWE123123");
        openApiModelObj.modelParamCount();
    }
}