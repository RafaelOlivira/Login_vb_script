-- phpMyAdmin SQL Dump
-- version 4.0.4.2
-- http://www.phpmyadmin.net
--
-- Máquina: localhost
-- Data de Criação: 25-Out-2025 às 23:58
-- Versão do servidor: 5.6.13
-- versão do PHP: 5.4.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de Dados: `cad_clientes_adsma2`
--
CREATE DATABASE IF NOT EXISTS `cad_clientes_adsma2` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `cad_clientes_adsma2`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_clientes`
--

CREATE TABLE IF NOT EXISTS `tb_clientes` (
  `id_cliente` int(100) NOT NULL AUTO_INCREMENT,
  `cpf` varchar(14) NOT NULL,
  `nome` varchar(60) NOT NULL,
  `data_nasc` varchar(10) NOT NULL,
  `fone` varchar(21) NOT NULL,
  `email` varchar(60) NOT NULL,
  `foto` varchar(225) NOT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Extraindo dados da tabela `tb_clientes`
--

INSERT INTO `tb_clientes` (`id_cliente`, `cpf`, `nome`, `data_nasc`, `fone`, `email`, `foto`) VALUES
(1, '111.111.111-11', 'RAFAE', '11/09/2025', '+55 (  )      -', 'RAFAS', '');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_usuarios`
--

CREATE TABLE IF NOT EXISTS `tb_usuarios` (
  `cpf` varchar(14) NOT NULL,
  `nome_completo` varchar(60) NOT NULL,
  `email` varchar(70) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `senha` varchar(50) NOT NULL,
  `status` varchar(50) NOT NULL,
  PRIMARY KEY (`cpf`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_usuarios`
--

INSERT INTO `tb_usuarios` (`cpf`, `nome_completo`, `email`, `usuario`, `senha`, `status`) VALUES
('111,111,111-11', 'rafael oliveira', 'rafael@gmail.com', 'rafael123', '123', 'ATIVO'),
('222,222,222-22', 'Humberto', 'humberto@gmail.com', 'humberto', '123', 'ATIVO'),
('333,333,333-33', 'Joanete', 'joanete@gmail.com', 'joanete', '123', 'ATIVO'),
('444,444,443-33', 'Maria', 'maria@gmail.com', 'maria', '123', 'ATIVO');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
