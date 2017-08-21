Use [Cupons]
GO

CREATE PROCEDURE [dbo].[uspClienteConsultarCPF]
@Cpf varchar(12)

as
begin

select  

	id,
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
from dbo.tblCliente
where cpf = @cpf
end
