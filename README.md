# Gestao-de-Estoque
<p>Este sistema tem como objetivo a gestão do estoque de empresas que fazem obras (construção civil).</p>

<h1>Como utilizar?</h1>
<p>Basta compilar o projeto e colocar o banco de dados (Banco_Sistema.mdb) na mesma pasta que o arquivo executável (GestãoEstoque\bin\debug). É possível então copiar os arquivos desta pasta e utilizar o sistema em qualquer local do computador. Existem 3 usuários pré-cadastrados no sistema (1, 2, 3), todos com senha 1234.</p>

<h1>Quais funcionalidades existem no projeto?</h1>
<p>É possível cadastrar materiais, tipos de materiais, unidades de medida, fornecedores, locais de armazenagem, usuários (administrador, auxiliar de estoque e supervisor), assim como tipos de transferência. Além disso, quando o assunto é operações, é possível dar entrada no estoque manualmente e por pedido de compra, sendo que no segundo caso resultará posteriormente em um recebimento (que poderá ser fracionado). Por fim, existe também a possibilidade de fazer as operações de entrada e saída das obras.</p>
  
<h1>Requisitos Mínimos</h1>
<ul>
  <li>Ter o SGBD Access instalado na máquina.</li>
  <li>Ter o sistema operacional windows instalado na máquina a utilizar o programa.</li>
</ul>

<h1>Tecnologias Utilizadas</h1>
<ul>
  <li>Visual Studio 2017 - C# (Windows Forms).</li>
  <li>Banco de dados Access (arquivo MDB para funcionar em versões mais antigas).</li>
  <li>Hash MD5 para guardar as senhas.</li>
  <li>Padrão arquitetural Em Camadas (3 camadas).</li>
</ul>

<h1>Observações</h1>
<p>Este sistema tem objetivo apenas educacional, sendo parte de um projeto da disciplina de Laboratório de Engenharia de Software, na Fatec São Paulo, curso de Análise e Desenvolvimento de Sistemas.</p>
  
