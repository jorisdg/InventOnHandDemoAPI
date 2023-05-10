using InventOnHandDemoAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapGet("/Warehouse", () =>
{
    return InventoryDB.GetWarehouses();

})
.WithName("GetWarehouses")
.WithOpenApi();

app.MapGet("/InventOnHand", () =>
{
    return InventoryDB.GetInventOnHand();

})
.WithName("GetInventOnHand")
.WithOpenApi();

app.MapGet("/Invent/{warehouse}", (string warehouse) =>
{
    return InventoryDB.GetInventOnHand(warehouse);

})
.WithName("GetWarehouseInvent")
.WithOpenApi();


app.Run();
