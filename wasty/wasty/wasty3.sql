PGDMP             	        
    z            wasty    14.5    14.5 !               0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    16506    wasty    DATABASE     i   CREATE DATABASE wasty WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'English_United States.1252';
    DROP DATABASE wasty;
                postgres    false            �            1255    16507    delete_cust(character varying)    FUNCTION     �   CREATE FUNCTION public.delete_cust(_customer_id character varying) RETURNS integer
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
       public          postgres    false            �            1255    16508    select_cust()    FUNCTION     L  CREATE FUNCTION public.select_cust() RETURNS TABLE(_customer_id character varying, _customer_name character varying, _customer_phone character varying, _customer_address character varying)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	select customer_id, customer_name, customer_phone, customer_address from customer;
end
$$;
 $   DROP FUNCTION public.select_cust();
       public          postgres    false            �            1255    16509    st_delete(character varying)    FUNCTION     �   CREATE FUNCTION public.st_delete(_waste_id character varying) RETURNS integer
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
       public          postgres    false            �            1255    16510 /   st_insert(character varying, character varying)    FUNCTION     =  CREATE FUNCTION public.st_insert(_waste_type character varying, _waste_price character varying) RETURNS integer
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
       public          postgres    false            �            1255    16511 B   st_insert(character varying, character varying, character varying)    FUNCTION     �  CREATE FUNCTION public.st_insert(_customer_name character varying, _customer_phone character varying, _customer_address character varying) RETURNS integer
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
       public          postgres    false            �            1255    16512    st_select()    FUNCTION     �   CREATE FUNCTION public.st_select() RETURNS TABLE(_waste_id character varying, _waste_type character varying, _waste_price character varying)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	select waste_id, waste_type, waste_price from waste;
end
$$;
 "   DROP FUNCTION public.st_select();
       public          postgres    false            �            1255    16513 B   st_update(character varying, character varying, character varying)    FUNCTION     R  CREATE FUNCTION public.st_update(_waste_id character varying, _waste_type character varying, _waste_price character varying) RETURNS integer
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
       public          postgres    false            �            1255    16514 U   st_update(character varying, character varying, character varying, character varying)    FUNCTION     �  CREATE FUNCTION public.st_update(_customer_id character varying, _customer_name character varying, _customer_phone character varying, _customer_address character varying) RETURNS integer
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
       public          postgres    false            �            1259    16515 
   account_id    SEQUENCE     s   CREATE SEQUENCE public.account_id
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 !   DROP SEQUENCE public.account_id;
       public          postgres    false            �            1259    16516    account    TABLE     �   CREATE TABLE public.account (
    account_id character varying(10) DEFAULT ('ST'::text || nextval('public.account_id'::regclass)) NOT NULL,
    account_username character varying(20) NOT NULL,
    account_password character varying(60) NOT NULL
);
    DROP TABLE public.account;
       public         heap    postgres    false    209            �            1259    16520    customer_id    SEQUENCE     t   CREATE SEQUENCE public.customer_id
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 "   DROP SEQUENCE public.customer_id;
       public          postgres    false            �            1259    16521    customer    TABLE       CREATE TABLE public.customer (
    customer_id character varying(100) DEFAULT ('ST'::text || nextval('public.customer_id'::regclass)) NOT NULL,
    customer_name character varying(40),
    customer_phone character varying(20),
    customer_address character varying(50) NOT NULL
);
    DROP TABLE public.customer;
       public         heap    postgres    false    211            �            1259    16525 	   record_id    SEQUENCE     r   CREATE SEQUENCE public.record_id
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
     DROP SEQUENCE public.record_id;
       public          postgres    false            �            1259    16526    records    TABLE     �   CREATE TABLE public.records (
    record_id character varying(100) DEFAULT ('ST'::text || nextval('public.record_id'::regclass)) NOT NULL,
    record_time date DEFAULT CURRENT_DATE,
    weight_of_goods real NOT NULL,
    total_price real NOT NULL
);
    DROP TABLE public.records;
       public         heap    postgres    false    213            �            1259    16531    waste_id    SEQUENCE     q   CREATE SEQUENCE public.waste_id
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
    DROP SEQUENCE public.waste_id;
       public          postgres    false            �            1259    16532    waste    TABLE     �   CREATE TABLE public.waste (
    waste_id character varying(100) DEFAULT ('ST'::text || nextval('public.waste_id'::regclass)) NOT NULL,
    waste_type character varying(30),
    waste_price character varying(30)
);
    DROP TABLE public.waste;
       public         heap    postgres    false    215                      0    16516    account 
   TABLE DATA           Q   COPY public.account (account_id, account_username, account_password) FROM stdin;
    public          postgres    false    210   �,                 0    16521    customer 
   TABLE DATA           `   COPY public.customer (customer_id, customer_name, customer_phone, customer_address) FROM stdin;
    public          postgres    false    212   �,                 0    16526    records 
   TABLE DATA           W   COPY public.records (record_id, record_time, weight_of_goods, total_price) FROM stdin;
    public          postgres    false    214   I-                 0    16532    waste 
   TABLE DATA           B   COPY public.waste (waste_id, waste_type, waste_price) FROM stdin;
    public          postgres    false    216   f-                  0    0 
   account_id    SEQUENCE SET     9   SELECT pg_catalog.setval('public.account_id', 1, false);
          public          postgres    false    209                       0    0    customer_id    SEQUENCE SET     9   SELECT pg_catalog.setval('public.customer_id', 2, true);
          public          postgres    false    211                       0    0 	   record_id    SEQUENCE SET     8   SELECT pg_catalog.setval('public.record_id', 1, false);
          public          postgres    false    213                       0    0    waste_id    SEQUENCE SET     6   SELECT pg_catalog.setval('public.waste_id', 4, true);
          public          postgres    false    215            y           2606    16537 $   account account_account_username_key 
   CONSTRAINT     k   ALTER TABLE ONLY public.account
    ADD CONSTRAINT account_account_username_key UNIQUE (account_username);
 N   ALTER TABLE ONLY public.account DROP CONSTRAINT account_account_username_key;
       public            postgres    false    210            {           2606    16539    account account_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.account
    ADD CONSTRAINT account_pkey PRIMARY KEY (account_id);
 >   ALTER TABLE ONLY public.account DROP CONSTRAINT account_pkey;
       public            postgres    false    210            }           2606    16541    customer customer_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.customer
    ADD CONSTRAINT customer_pkey PRIMARY KEY (customer_id);
 @   ALTER TABLE ONLY public.customer DROP CONSTRAINT customer_pkey;
       public            postgres    false    212                       2606    16543    records records_pkey 
   CONSTRAINT     Y   ALTER TABLE ONLY public.records
    ADD CONSTRAINT records_pkey PRIMARY KEY (record_id);
 >   ALTER TABLE ONLY public.records DROP CONSTRAINT records_pkey;
       public            postgres    false    214            �           2606    16545    waste waste_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.waste
    ADD CONSTRAINT waste_pkey PRIMARY KEY (waste_id);
 :   ALTER TABLE ONLY public.waste DROP CONSTRAINT waste_pkey;
       public            postgres    false    216                  x������ � �         ;   x�1����LQp�/JO-�4�04537265637�44�PH,�Vp,K�+M����� e�+            x������ � �         $   x�1�L�/��Q(�I,.���4100������ d�     