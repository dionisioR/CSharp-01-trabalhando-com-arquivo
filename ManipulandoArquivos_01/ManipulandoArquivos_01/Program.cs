using System.Text;


//var enderecoDoArquivo = "document/contas.txt";
var enderecoDoArquivo = "document/contas.txt";
var numeroDeBytesLidos = -1;
var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

// public override int Read(byte[] array, int offset, int count);
// byte[] array = buffer onde serão armazenadas as informações temporariamente
// int offset = início - de onde os dados começaram a ser lidos
// int count = fim - onde os dados param de ser lidos.

var buffer = new byte[1024]; // 1Kb

while(numeroDeBytesLidos != 0) {
    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
    EscreverBuffer(buffer);
    
}

// Devoluções:
// O número total de bytes lidos do buffer.
// Isso pode ser menos que o número de bytes solicitado se esse número de byes não estiver disponível no momento,
// ou zero, se o final do fluxo for atingido.


Console.ReadLine();

// ----------------------------------------------------------

static void EscreverBuffer(byte[] buffer) {
    var utf8 = new UTF8Encoding();

    var texto = utf8.GetString(buffer);
    Console.Write(texto);
    // vai imprimir os bytes
    // foreach (var meyByte in buffer) {
    //     Console.Write(meyByte + " ");
    // }
}