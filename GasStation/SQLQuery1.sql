SELECT capacidadeMaxima,DescBomba,QtdCombustivelAtual,ValorCombustivel,DescricaoCombustivel FROM tbBOMBA_COMBUSTIVEL inner join tbCOMBUSTIVEL on (tbBOMBA_COMBUSTIVEL.TipoCombustivel=tbCOMBUSTIVEL.CodCombustivel) WHERE CodBomba = 1;


UPDATE tbBOMBA_COMBUSTIVEL SET QtdCombustivelAtual = 300 WHERE CodBomba = 1;