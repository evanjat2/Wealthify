---- table pengguna ----
CREATE TABLE IF NOT EXISTS public.pengguna
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
CREATE TABLE IF NOT EXISTS public.artikel
(
    artikel_id serial primary key,
    kategori character varying(100) COLLATE pg_catalog."default" NOT NULL,
    judul character varying(50) COLLATE pg_catalog."default" NOT NULL,
    konten character varying COLLATE pg_catalog."default" NOT NULL
)


---- table kantong ----

-- DROP TABLE IF EXISTS public.kantong;

CREATE TABLE IF NOT EXISTS public.kantong
(
    jenis_kantong character varying(20) COLLATE pg_catalog."default",
    nama_kantong character varying(20) COLLATE pg_catalog."default",
    saldo integer,
    user_id integer,
    nomor_kantong integer NOT NULL DEFAULT nextval('kantong_nomor_kantong_seq'::regclass),
    CONSTRAINT kantong_pk PRIMARY KEY (nomor_kantong),
    CONSTRAINT kantong_fk FOREIGN KEY (user_id)
        REFERENCES public.pengguna (user_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)


---- table keuangan ----

-- DROP TABLE IF EXISTS public.keuangan;

CREATE TABLE IF NOT EXISTS public.keuangan
(
    jenis_transaksi character varying(50) COLLATE pg_catalog."default",
    kategori_transaksi character varying(50) COLLATE pg_catalog."default",
    nominal integer,
    catatan character varying(50) COLLATE pg_catalog."default",
    user_id integer,
    nomor_kantong integer,
    nomor_transaksi integer NOT NULL DEFAULT nextval('kantong_nomor_kantong_seq'::regclass),
    nama_kantong character varying(50) COLLATE pg_catalog."default",
    CONSTRAINT keuangan_pk PRIMARY KEY (nomor_transaksi),
    CONSTRAINT keuangan_fk1 FOREIGN KEY (user_id)
        REFERENCES public.pengguna (user_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID,
    CONSTRAINT keuangan_fk2 FOREIGN KEY (nomor_kantong)
        REFERENCES public.kantong (nomor_kantong) MATCH SIMPLE
        ON UPDATE CASCADE
        ON DELETE CASCADE
        NOT VALID
)


---- tambah kantong ----
create FUNCTION tambah_kantong
(
	_jenis_kantong character varying,
    _nama_kantong character varying,
    _saldo int
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


---- lihat kantong ----
create FUNCTION lihat_kantong()
returns table
(
	_jenis_kantong character varying,
    _nama_kantong character varying,
    _saldo character varying,
)
language plpgsql
as
'
BEGIN
	return query
	select jenis_kantong, nama_kantong, saldo from kantong;
end;
'


---- tambah keuangan ----
create or replace FUNCTION tambah_keuangan
(
	_nama_kantong character varying,
	_jenis_transaksi character varying,
    _kategori_transaksi character varying,
    _nominal int,
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


---- lihat keuangan ----
CREATE OR REPLACE FUNCTION public.lihat_keuangan(
	)
    RETURNS TABLE(_jenis_transaksi character varying, _kategori_transaksi character varying, _nominal integer, _catatan character varying) 
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE PARALLEL UNSAFE
    ROWS 1000

AS $BODY$
BEGIN
	return query
	select jenis_transaksi, kategori_transaksi, nominal, catatan from keuangan;
end;
$BODY$;