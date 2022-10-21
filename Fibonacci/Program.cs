int agora = 1;
int penultimo = 0;

Console.WriteLine(agora);
for (int i = 1; i <= 20; i++)
{
    var next = agora + penultimo;
    Console.WriteLine(next);
    penultimo = agora;
    agora = next;
}