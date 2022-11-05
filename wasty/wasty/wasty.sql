PGDMP     9                
    z            wasty    14.5    14.5     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16482    wasty    DATABASE     i   CREATE DATABASE wasty WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'English_United States.1252';
    DROP DATABASE wasty;
                postgres    false            �            1255    16493    st_delete(character varying)    FUNCTION     �   CREATE FUNCTION public.st_delete(_waste_id character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	DELETE FROM public.waste
	WHERE waste_id=_waste_id;
	if found then
		return 1;
	else
		return 0;
	end if;
end 
$$;
 =   DROP FUNCTION public.st_delete(_waste_id character varying);
       public          postgres    false            �            1255    16490 /   st_insert(character varying, character varying)    FUNCTION     =  CREATE FUNCTION public.st_insert(_waste_type character varying, _waste_price character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	insert into public.waste
	(
		waste_type, 
		waste_price
	)
	values
(
		_waste_type, 
		_waste_price
	);
	if found then
		return 1;
	else
		return 0;
	end if;
end
$$;
 _   DROP FUNCTION public.st_insert(_waste_type character varying, _waste_price character varying);
       public          postgres    false            �            1255    16491    st_select()    FUNCTION     �   CREATE FUNCTION public.st_select() RETURNS TABLE(_waste_id character varying, _waste_type character varying, _waste_price character varying)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	select waste_id, waste_type, waste_price from waste;
end
$$;
 "   DROP FUNCTION public.st_select();
       public          postgres    false            �            1255    16492 B   st_update(character varying, character varying, character varying)    FUNCTION     R  CREATE FUNCTION public.st_update(_waste_id character varying, _waste_type character varying, _waste_price character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
	update waste SET
		waste_type=_waste_type,
		waste_price=_waste_price
	WHERE waste_id=_waste_id;
	if found then
		return 1;
	else
		return 0;
	end if;
end
$$;
 |   DROP FUNCTION public.st_update(_waste_id character varying, _waste_type character varying, _waste_price character varying);
       public          postgres    false            �            1259    16483    waste_id    SEQUENCE     q   CREATE SEQUENCE public.waste_id
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
    DROP SEQUENCE public.waste_id;
       public          postgres    false            �            1259    16484    waste    TABLE     �   CREATE TABLE public.waste (
    waste_id character varying(100) DEFAULT ('ST'::text || nextval('public.waste_id'::regclass)) NOT NULL,
    waste_type character varying(30),
    waste_price character varying(30)
);
    DROP TABLE public.waste;
       public         heap    postgres    false    209            �          0    16484    waste 
   TABLE DATA           B   COPY public.waste (waste_id, waste_type, waste_price) FROM stdin;
    public          postgres    false    210   �       �           0    0    waste_id    SEQUENCE SET     6   SELECT pg_catalog.setval('public.waste_id', 4, true);
          public          postgres    false    209            b           2606    16489    waste waste_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.waste
    ADD CONSTRAINT waste_pkey PRIMARY KEY (waste_id);
 :   ALTER TABLE ONLY public.waste DROP CONSTRAINT waste_pkey;
       public            postgres    false    210            �   $   x�1�L�/��Q(�I,.���4100������ d�     