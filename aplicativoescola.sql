-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 19/03/2026 às 14:07
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `aplicativoescola`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `aluno`
--

CREATE TABLE `aluno` (
  `nomeAluno` varchar(100) NOT NULL,
  `dataNascimentoAluno` varchar(10) NOT NULL,
  `nomeResponsavel` varchar(100) NOT NULL,
  `dataNascimentoResponsavel` varchar(10) NOT NULL,
  `telefoneResponsavel` varchar(14) NOT NULL,
  `cpfResponsavel` varchar(14) NOT NULL,
  `turmas` varchar(30) NOT NULL,
  `idAluno` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `aluno`
--

INSERT INTO `aluno` (`nomeAluno`, `dataNascimentoAluno`, `nomeResponsavel`, `dataNascimentoResponsavel`, `telefoneResponsavel`, `cpfResponsavel`, `turmas`, `idAluno`) VALUES
('Gabriela dos Santos', '12/08/2005', 'Maria dos Santos', '30/06/1976', '(81)98779-3130', '465,478,444-12', '', 6),
('Mafalda dos Santos', '12/08/2005', 'José dos Santos', '30/06/1976', '(81)98779-3130', '465,478,444-45', '', 7),
('Joaquim Martins de Souza', '12/08/2005', 'Felipe dos Santos', '30/06/1976', '(81)98779-3130', '465,738,444-45', '', 8);

-- --------------------------------------------------------

--
-- Estrutura para tabela `professor`
--

CREATE TABLE `professor` (
  `cpf` varchar(14) NOT NULL,
  `usuario` varchar(30) DEFAULT NULL,
  `senha` varchar(20) NOT NULL,
  `Nome` varchar(100) DEFAULT NULL,
  `dataNascimento` varchar(10) NOT NULL,
  `cidade` varchar(50) NOT NULL,
  `estado` varchar(30) NOT NULL,
  `telefone` varchar(14) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `professor`
--

INSERT INTO `professor` (`cpf`, `usuario`, `senha`, `Nome`, `dataNascimento`, `cidade`, `estado`, `telefone`) VALUES
('119,158,055-73', 'giovannirlmartins@gmail.com', '1234', 'Giovanni Rodrigues de Lima Martins', '12/05/1998', 'Paulista', 'Pernambuco', '(81)98588-8225');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `aluno`
--
ALTER TABLE `aluno`
  ADD PRIMARY KEY (`idAluno`);

--
-- Índices de tabela `professor`
--
ALTER TABLE `professor`
  ADD PRIMARY KEY (`cpf`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `aluno`
--
ALTER TABLE `aluno`
  MODIFY `idAluno` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
