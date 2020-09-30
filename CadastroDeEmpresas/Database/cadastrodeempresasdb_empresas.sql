-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: cadastrodeempresasdb
-- ------------------------------------------------------
-- Server version	8.0.20

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `empresas`
--

DROP TABLE IF EXISTS `empresas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empresas` (
  `cnpj` varchar(18) NOT NULL,
  `tipo` varchar(6) NOT NULL,
  `abertura` varchar(10) NOT NULL,
  `nome` varchar(100) DEFAULT NULL,
  `fantasia` varchar(100) DEFAULT NULL,
  `natureza_juridica` varchar(50) DEFAULT NULL,
  `logradouro` varchar(50) DEFAULT NULL,
  `numero` varchar(9) DEFAULT NULL,
  `complemento` varchar(100) DEFAULT NULL,
  `cep` varchar(10) DEFAULT NULL,
  `bairro` varchar(50) DEFAULT NULL,
  `municipio` varchar(50) DEFAULT NULL,
  `porte` varchar(20) DEFAULT NULL,
  `uf` varchar(2) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `telefone` varchar(100) DEFAULT NULL,
  `efr` varchar(100) DEFAULT NULL,
  `situacao` varchar(50) DEFAULT NULL,
  `data_situacao` varchar(10) DEFAULT NULL,
  `motivo_situacao` varchar(100) DEFAULT NULL,
  `situacao_especial` varchar(100) DEFAULT NULL,
  `data_situacao_especial` varchar(10) DEFAULT NULL,
  `capital_social` decimal(12,2) DEFAULT NULL,
  PRIMARY KEY (`cnpj`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empresas`
--

LOCK TABLES `empresas` WRITE;
/*!40000 ALTER TABLE `empresas` DISABLE KEYS */;
INSERT INTO `empresas` VALUES ('02.183.757/0001-93','MATRIZ','06/10/1997','EDITORA ABRIL S.A.','','204-6 - Sociedade Anônima Aberta','','','','','','','DEMAIS','','cpfiscal@abril.com.br','(11) 3037-4189','','BAIXADA','30/09/2012','INCORPORACAO','','',0.00),('07.200.194/0003-80','FILIAL','24/11/2011','CAL-COMP INDUSTRIA E COMERCIO DE ELETRONICOS E INFORMATICA LTDA.','','206-2 - Sociedade Empresária Limitada','AV TORQUATO TAPAJOS','7503','GALPAO2 MODULOS 19 PARTE 20 E 21','69.041-025','TARUMA','MANAUS','DEMAIS','AM','paulofeitoza@ribeiroefeitozaadvogados.com','(92) 3611-1581','','ATIVA','24/11/2011','','','',0.00),('11.609.581/0014-02','FILIAL','09/11/2018','A. R. C. LOGISTICA E ALIMENTOS LTDA','','206-2 - Sociedade Empresária Limitada','RODOVIA SP 107 KM 3,5','S/N','SALA 01','13.908-901','JARDIM VISTA ALEGRE (ARCADAS)','AMPARO','DEMAIS','SP','deraldo.nogueira@lideralimentos.com.br','(18) 2101-3900','','ATIVA','09/11/2018','','','',0.00),('24.353.832/0001-50','MATRIZ','10/03/2016','FOOD BRANDS INDUSTRIA DE PRODUTOS ALIMENTICIOS S/A','FOOD BRANDS','205-4 - Sociedade Anônima Fechada','RODOVIA ANHANGUERA','KM 51','GALPAO2A','13.205-700','TIJUCO PRETO','JUNDIAI','DEMAIS','SP','marcio@kisabor.ind.br','(11) 4536-4500','','ATIVA','10/03/2016','','','',3000000.00),('27.865.757/0001-02','MATRIZ','31/01/1986','GLOBO COMUNICACAO E PARTICIPACOES S/A','TV/REDE/CANAIS/G2C+GLOBO SOMLIVRE GLOBO.COM GLOBOPLAY','205-4 - Sociedade Anônima Fechada','R LOPES QUINTAS','303','','22.460-901','JARDIM BOTANICO','RIO DE JANEIRO','DEMAIS','RJ','','(21) 2155-4551/ (21) 2155-4552','','ATIVA','03/11/2005','','','',6453568523.86),('44.990.901/0001-43','MATRIZ','01/07/1966','TILIBRA PRODUTOS DE PAPELARIA LTDA.','TILIBRA','206-2 - Sociedade Empresária Limitada','R AIMORES','6-9','','17.013-900','VILA CARDIA','BAURU','DEMAIS','SP','contabilfiscal@tilibra.com.br','(14) 3235-4119/ (14) 2109-6431','','ATIVA','03/11/2005','','','',350017967.00),('64.836.000/0004-51','FILIAL','17/09/2019','L R LAUREANO','PEIXARIA IPANEMA','213-5 - Empresário (Individual)','AVENIDA GISELE CONSTANTINO','1850','LOJA 319','18.110-650','PARQUE BELA VISTA','VOTORANTIM','MICRO EMPRESA','SP','julianosantoslaureano@yahoo.com.br','(15) 3232-5483 / (15) 3224-3445','','ATIVA','17/09/2019','','','',0.00),('70.950.571/0001-72','MATRIZ','16/04/1993','FEDERACAO MINEIRA DOS EXPOSITORES DAS F A A E MANUFATUR','FEMIART','399-9 - Associação Privada','','','','','','','DEMAIS','','','','','INAPTA','06/12/2018','OMISSAO DE DECLARACOES','','',0.00);
/*!40000 ALTER TABLE `empresas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-08-28 22:12:56
