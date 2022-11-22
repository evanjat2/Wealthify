CREATE DATABASE wealthify;

-- Tabel Pengguna --
CREATE TABLE IF NOT EXISTS pengguna
(
    user_id serial primary key,
    username character varying(50) COLLATE pg_catalog."default" NOT NULL,
    email character varying(50) COLLATE pg_catalog."default" NOT NULL,
    no_hp character varying(20) DEFAULT 0,
    password character varying(50) COLLATE pg_catalog."default" NOT NULL,
    saldo int default 0,
    isAdmin bool default false
)

-- Tabel Artikel --
CREATE TABLE IF NOT EXISTS artikel
(
    artikel_id serial primary key,
    kategori character varying(100) COLLATE pg_catalog."default" NOT NULL,
    judul character varying(50) COLLATE pg_catalog."default" NOT NULL,
    konten character varying COLLATE pg_catalog."default" NOT NULL
)

-- Sequence Kantong --
CREATE SEQUENCE seq_kantong
	start 1
	increment 1;

-- Tabel Kantong --
CREATE TABLE IF NOT EXISTS kantong
(
    nomor_kantong integer primary key default nextval('seq_kantong'),
	jenis_kantong character varying(50) COLLATE pg_catalog."default" NOT NULL,
    nama_kantong character varying(50) COLLATE pg_catalog."default" NOT NULL,
    saldo integer default 0
)

-- Sequence Kantong --
CREATE SEQUENCE seq_keuangan
	start 1
	increment 1;
	
-- Tabel Keuangan --
CREATE TABLE IF NOT EXISTS keuangan
(
	nomor_transaksi integer primary key default nextval('seq_keuangan'),
	nama_kantong character varying(50) COLLATE pg_catalog."default" NOT NULL,
    jenis_transaksi character varying(50) COLLATE pg_catalog."default" NOT NULL,
    kategori_transaksi character varying(50) COLLATE pg_catalog."default" NOT NULL,
    nominal integer NOT NULL,
    catatan character varying(50) COLLATE pg_catalog."default"
)

-- Function Create Kantong --
CREATE OR REPLACE FUNCTION tambah_kantong
(
	_jenis_kantong character varying,
    _nama_kantong character varying,
    _saldo integer
)
returns int AS
'
BEGIN
	insert into kantong
	(
		jenis_kantong,
		nama_kantong,
		saldo
	)
	values
	(
		_jenis_kantong,
    	_nama_kantong,
    	_saldo
	);
	if found then
		return 1;
	else
		return 0;
	end if;
end;
'
language plpgsql;

-- Function Read Kantong --
CREATE OR REPLACE FUNCTION lihat_kantong()
returns table
(
	_jenis_kantong character varying,
    _nama_kantong character varying,
    _saldo integer
)
language plpgsql
as
'
BEGIN
	return query
	select jenis_kantong, nama_kantong, saldo from kantong;
end;
'

-- Function Update Kantong --
CREATE OR REPLACE FUNCTION ubah_kantong
(
	_nomor_kantong integer,
	_jenis_kantong character varying,
	_nama_kantong character varying,
	_saldo integer
)
returns int AS
'
BEGIN
	update kantong set
		jenis_kantong = _jenis_kantong,
		nama_kantong = _nama_kantong,
		saldo = _saldo
	where nomor_kantong = _nomor_kantong;
	if found then
		return 1;
	else
		return 0;
	end if;
end
'
language plpgsql

-- Function Create Keuangan --
CREATE OR REPLACE FUNCTION tambah_keuangan
(
	_nama_kantong character varying,
	_jenis_transaksi character varying,
    _kategori_transaksi character varying,
    _nominal integer,
	_catatan character varying
)
returns int AS
'
BEGIN
	insert into keuangan
	(
		nama_kantong,
		jenis_transaksi,
		kategori_transaksi,
		nominal,
		catatan
	)
	values
	(
		_nama_kantong,
		_jenis_transaksi,
    	_kategori_transaksi,
    	_nominal,
		_catatan
	);
	if found then
		return 1;
	else
		return 0;
	end if;
end;
'
language plpgsql;

-- Function Read Keuangan --
CREATE OR REPLACE FUNCTION lihat_keuangan()
returns table
(
	_nama_kantong character varying,
	_jenis_transaksi character varying,
	_kategori_transaksi character varying,
	_nominal integer,
	_catatan character varying
)
language plpgsql
as
'
BEGIN
	return query
	select nama_kantong, jenis_transaksi, kategori_transaksi, nominal, catatan from keuangan;
end;
'
