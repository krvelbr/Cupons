Use [Cupons]
GO

CREATE PROCEDURE [uspClienteInserir] 
@Nome varchar(60),
@Cpf varchar(12),
@RG varchar(12),
@Nascimento date,
@Sexo varchar(1),  -- aceita F ou M

@Endereco varchar(50),
@EnderecoNumero varchar(8),
@EnderecoComplemento varchar(30),
@Bairro varchar(40),
@Cidade varchar(50),
@Estado varchar(2),
@CEP varchar(10),

@FoneFixo varchar(12),
@FoneCelular1 varchar(12),
@FoneCelular2 varchar(12),
@FoneCelular3 varchar(12),
@Whatsapp varchar(12),
@Email varchar(35),
@Facebook varchar(50),
@Twitter varchar(50),
@Observacao text,
@Foto image
	
AS
BEGIN

insert into dbo.tblCliente
(
Nome,
Cpf,
RG,
DataNasc,
Sexo,  -- aceita F ou M

Endereco,
EnderecoNumero,
EnderecoComplemento,
Bairro,
Cidade,
Estado,
CEP,

FoneFixo,
FoneCelular1,
FoneCelular2,
FoneCelular3,

Whatsapp,
Email,
Facebook,
Twitter,
Observacao,
Foto

)

Values
(
@Nome,
@Cpf,
@RG,
@Nascimento,
@Sexo,  -- aceita F ou M

@Endereco,
@EnderecoNumero,
@EnderecoComplemento,
@Bairro,
@Cidade,
@Estado,
@CEP,

@FoneFixo,
@FoneCelular1,
@FoneCelular2,
@FoneCelular3,
@Whatsapp,
@Email,
@Facebook,
@Twitter,
@Observacao,
@Foto

)

Select @@Identity as Retorno
end
