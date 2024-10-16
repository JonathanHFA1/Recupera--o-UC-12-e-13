using Recuperação_UC_12_e_13;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Projeto Web - REC");

Banco banco = new Banco();
app.MapGet("/listaClientes",(HttpContext context)=>{
    context.Response.WriteAsync(banco.GetListaString());
});

app.UseStaticFiles();


app.Run();
