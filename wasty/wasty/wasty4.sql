PGDMP     3                
    z            wasty    14.5    14.5 %               0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    16395    wasty    DATABASE     e   CREATE DATABASE wasty WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'English_Indonesia.1252';
    DROP DATABASE wasty;
                postgres    false            �            1255    16396    delete_cust(character varying)    FUNCTION     �   CREATE FUNCTION public.delete_cust(_customer_id character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	DELETE FROM public.customer
	WHERE customer_id=_customer_id;
	if found then
		return 1;
	else
		return 0;
	end if;
end 
$$;
 B   DROP FUNCTION public.delete_cust(_customer_id character varying);
       public          postgres    false            �            1255    16397    select_cust()    FUNCTION     L  CREATE FUNCTION public.select_cust() RETURNS TABLE(_customer_id character varying, _customer_name character varying, _customer_phone character varying, _customer_address character varying)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	select customer_id, customer_name, customer_phone, customer_address from customer;
end
$$;
 $   DROP FUNCTION public.select_cust();
       public          postgres    false            �            1255    16440    select_record()    FUNCTION     G  CREATE FUNCTION public.select_record() RETURNS TABLE(_record_id character varying, _customer_name character varying, _record_time date, _weight_of_goods real, _total_price real)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	select record_id, customer_name, record_time, weight_of_goods, total_price from records;
end
$$;
 &   DROP FUNCTION public.select_record();
       public          postgres    false            �            1255    16398    st_delete(character varying)    FUNCTION     �   CREATE FUNCTION public.st_delete(_waste_id character varying) RETURNS integer
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
       public          postgres    false            �            1255    16399 /   st_insert(character varying, character varying)    FUNCTION     =  CREATE FUNCTION public.st_insert(_waste_type character varying, _waste_price character varying) RETURNS integer
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
       public          postgres    false            �            1255    16400 B   st_insert(character varying, character varying, character varying)    FUNCTION     �  CREATE FUNCTION public.st_insert(_customer_name character varying, _customer_phone character varying, _customer_address character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	insert into public.customer
	(
		customer_name, 
		customer_phone,
		customer_address
	)
	values
	(
		_customer_name,
		_customer_phone,
		_customer_address
	);
	if found then
		return 1;
	else
		return 0;
	end if;
end
$$;
 �   DROP FUNCTION public.st_insert(_customer_name character varying, _customer_phone character varying, _customer_address character varying);
       public          postgres    false            �            1255    16439 /   st_insert_record(real, real, character varying)    FUNCTION     �  CREATE FUNCTION public.st_insert_record(_weight_of_goods real, _total_price real, _customer_name character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	insert into public.records
	(
		weight_of_goods, 
		total_price,
		customer_name
	)
	values
(
		_weight_of_goods, 
		_total_price,
		_customer_name
	);
	if found then
		return 1;
	else
		return 0;
	end if;
end
$$;
 s   DROP FUNCTION public.st_insert_record(_weight_of_goods real, _total_price real, _customer_name character varying);
       public          postgres    false            �            1255    16441 5   st_insert_record(date, real, real, character varying)    FUNCTION     �  CREATE FUNCTION public.st_insert_record(_record_time date, _weight_of_goods real, _total_price real, _customer_name character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	insert into public.records
	(
		record_date,
		weight_of_goods, 
		total_price,
		customer_name
	)
	values
(
		_record_date,
		_weight_of_goods, 
		_total_price,
		_customer_name
	);
	if found then
		return 1;
	else
		return 0;
	end if;
end
$$;
 �   DROP FUNCTION public.st_insert_record(_record_time date, _weight_of_goods real, _total_price real, _customer_name character varying);
       public          postgres    false            �            1255    16442 B   st_insert_record(character varying, real, real, character varying)    FUNCTION     �  CREATE FUNCTION public.st_insert_record(_record_time character varying, _weight_of_goods real, _total_price real, _customer_name character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	insert into public.records
	(
		record_time,
		weight_of_goods, 
		total_price,
		customer_name
	)
	values
(
		TO_DATE(_record_time, 'YYYY/MM/DD'),
		_weight_of_goods, 
		_total_price,
		_customer_name
	);
	if found then
		return 1;
	else
		return 0;
	end if;
end
$$;
 �   DROP FUNCTION public.st_insert_record(_record_time character varying, _weight_of_goods real, _total_price real, _customer_name character varying);
       public          postgres    false            �            1255    16401    st_select()    FUNCTION     �   CREATE FUNCTION public.st_select() RETURNS TABLE(_waste_id character varying, _waste_type character varying, _waste_price character varying)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	select waste_id, waste_type, waste_price from waste;
end
$$;
 "   DROP FUNCTION public.st_select();
       public          postgres    false            �            1255    16402 B   st_update(character varying, character varying, character varying)    FUNCTION     R  CREATE FUNCTION public.st_update(_waste_id character varying, _waste_type character varying, _waste_price character varying) RETURNS integer
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
       public          postgres    false            �            1255    16403 U   st_update(character varying, character varying, character varying, character varying)    FUNCTION     �  CREATE FUNCTION public.st_update(_customer_id character varying, _customer_name character varying, _customer_phone character varying, _customer_address character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
	update customer SET
		customer_name = _customer_name,
		customer_phone = _customer_phone,
		customer_address = _customer_address
	WHERE customer_id=_customer_id;
	if found then
		return 1;
	else
		return 0;
	end if;
end
$$;
 �   DROP FUNCTION public.st_update(_customer_id character varying, _customer_name character varying, _customer_phone character varying, _customer_address character varying);
       public          postgres    false            �            1259    16404 
   account_id    SEQUENCE     s   CREATE SEQUENCE public.account_id
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 !   DROP SEQUENCE public.account_id;
       public          postgres    false            �            1259    16405    account    TABLE     �   CREATE TABLE public.account (
    account_id character varying(10) DEFAULT ('ST'::text || nextval('public.account_id'::regclass)) NOT NULL,
    account_username character varying(20) NOT NULL,
    account_password character varying(60) NOT NULL
);
    DROP TABLE public.account;
       public         heap    postgres    false    209            �            1259    16409    customer_id    SEQUENCE     t   CREATE SEQUENCE public.customer_id
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 "   DROP SEQUENCE public.customer_id;
       public          postgres    false            �            1259    16410    customer    TABLE       CREATE TABLE public.customer (
    customer_id character varying(100) DEFAULT ('ST'::text || nextval('public.customer_id'::regclass)) NOT NULL,
    customer_name character varying(40),
    customer_phone character varying(20),
    customer_address character varying(50) NOT NULL
);
    DROP TABLE public.customer;
       public         heap    postgres    false    211            �            1259    16414 	   record_id    SEQUENCE     r   CREATE SEQUENCE public.record_id
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
     DROP SEQUENCE public.record_id;
       public          postgres    false            �            1259    16415    records    TABLE     -  CREATE TABLE public.records (
    record_id character varying(100) DEFAULT ('ST'::text || nextval('public.record_id'::regclass)) NOT NULL,
    record_time date DEFAULT CURRENT_DATE,
    weight_of_goods real NOT NULL,
    total_price real NOT NULL,
    customer_name character varying(100) NOT NULL
);
    DROP TABLE public.records;
       public         heap    postgres    false    213            �            1259    16420    waste_id    SEQUENCE     q   CREATE SEQUENCE public.waste_id
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
    DROP SEQUENCE public.waste_id;
       public          postgres    false            �            1259    16421    waste    TABLE     �   CREATE TABLE public.waste (
    waste_id character varying(100) DEFAULT ('ST'::text || nextval('public.waste_id'::regclass)) NOT NULL,
    waste_type character varying(30),
    waste_price character varying(30)
);
    DROP TABLE public.waste;
       public         heap    postgres    false    215                      0    16405    account 
   TABLE DATA           Q   COPY public.account (account_id, account_username, account_password) FROM stdin;
    public          postgres    false    210   �7                 0    16410    customer 
   TABLE DATA           `   COPY public.customer (customer_id, customer_name, customer_phone, customer_address) FROM stdin;
    public          postgres    false    212   �7                 0    16415    records 
   TABLE DATA           f   COPY public.records (record_id, record_time, weight_of_goods, total_price, customer_name) FROM stdin;
    public          postgres    false    214   08                 0    16421    waste 
   TABLE DATA           B   COPY public.waste (waste_id, waste_type, waste_price) FROM stdin;
    public          postgres    false    216   �8                  0    0 
   account_id    SEQUENCE SET     9   SELECT pg_catalog.setval('public.account_id', 1, false);
          public          postgres    false    209                        0    0    customer_id    SEQUENCE SET     9   SELECT pg_catalog.setval('public.customer_id', 2, true);
          public          postgres    false    211            !           0    0 	   record_id    SEQUENCE SET     7   SELECT pg_catalog.setval('public.record_id', 7, true);
          public          postgres    false    213            "           0    0    waste_id    SEQUENCE SET     6   SELECT pg_catalog.setval('public.waste_id', 7, true);
          public          postgres    false    215            }           2606    16426 $   account account_account_username_key 
   CONSTRAINT     k   ALTER TABLE ONLY public.account
    ADD CONSTRAINT account_account_username_key UNIQUE (account_username);
 N   ALTER TABLE ONLY public.account DROP CONSTRAINT account_account_username_key;
       public            postgres    false    210                       2606    16428    account account_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.account
    ADD CONSTRAINT account_pkey PRIMARY KEY (account_id);
 >   ALTER TABLE ONLY public.account DROP CONSTRAINT account_pkey;
       public            postgres    false    210            �           2606    16430    customer customer_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.customer
    ADD CONSTRAINT customer_pkey PRIMARY KEY (customer_id);
 @   ALTER TABLE ONLY public.customer DROP CONSTRAINT customer_pkey;
       public            postgres    false    212            �           2606    16432    records records_pkey 
   CONSTRAINT     Y   ALTER TABLE ONLY public.records
    ADD CONSTRAINT records_pkey PRIMARY KEY (record_id);
 >   ALTER TABLE ONLY public.records DROP CONSTRAINT records_pkey;
       public            postgres    false    214            �           2606    16434    waste waste_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.waste
    ADD CONSTRAINT waste_pkey PRIMARY KEY (waste_id);
 :   ALTER TABLE ONLY public.waste DROP CONSTRAINT waste_pkey;
       public            postgres    false    216                  x������ � �         ;   x�1����LQp�/JO-�4�04537265637�44�PH,�Vp,K�+M����� e�+         S   x�1�4202�54�54�44�41 N��������"��Sd5F��*�PL������H��D�؀�Ј�Ô=... Y�!A         $   x�1�L�/��Q(�I,.���4100������ d�     