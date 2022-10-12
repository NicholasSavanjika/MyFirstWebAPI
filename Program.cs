var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => AddTwoIntergers(2, 5));

// map a new get route to /add
app.MapGet("/add", () => AddTwoIntergers(9, 8));

// parameter routing
app.MapGet("/add/{input1}/{input2}", (int input1, int input2) => AddTwoIntergers(input1, input2));

app.Run();

// function to add two integers together
int AddTwoIntergers(int num1, int num2) {
    int ans = num1 + num2;
    return ans;
}
