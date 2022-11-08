---- table pengguna ----
CREATE TABLE IF NOT EXISTS public.pengguna
(
    user_id integer NOT NULL,
    username character varying(20) COLLATE pg_catalog."default" NOT NULL,
    email character varying(20) COLLATE pg_catalog."default" NOT NULL,
    no_hp integer NOT NULL,
    password character varying(20) COLLATE pg_catalog."default" NOT NULL,
    saldo double precision,
    CONSTRAINT pengguna_pk PRIMARY KEY (user_id)
)


---- table kantong ----
CREATE TABLE IF NOT EXISTS public.kantong
(
    nomor_kantong integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 9223372036854775807 CACHE 1 ),
    jenis_kantong character varying(20) COLLATE pg_catalog."default",
    nama_kantong character varying(20) COLLATE pg_catalog."default",
    saldo double precision,
    user_id integer,
    CONSTRAINT kantong_pk PRIMARY KEY (nomor_kantong),
    CONSTRAINT kantong_fk FOREIGN KEY (user_id)
        REFERENCES public.pengguna (user_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)


---- tambah kantong ----
create FUNCTION tambah_kantong
(
	_jenis_kantong character varying,
    _nama_kantong character varying,
    _saldo double precision
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
    _saldo double precision
)
language plpgsql
as
'
BEGIN
	return query
	select jenis_kantong, nama_kantong, saldo from kantong;
end;
'