PGDMP     8                 
    z            wasty    14.5    14.5 ,    (           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            )           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            *           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            +           1262    16547    wasty    DATABASE     i   CREATE DATABASE wasty WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'English_United States.1252';
    DROP DATABASE wasty;
                postgres    false            ?            1255    16623 /   adm_login(character varying, character varying)    FUNCTION     P  CREATE FUNCTION public.adm_login(_adm_email character varying, _adm_pass character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	if(select count(*) from admin_tbl  where adm_email= _adm_email and adm_pass = _adm_pass) > 0  then
		return 1; -- login successfully --
	else
		return 0; -- login failed --
	end if;
end
$$;
 [   DROP FUNCTION public.adm_login(_adm_email character varying, _adm_pass character varying);
       public          postgres    false            ?            1255    16548    delete_cust(character varying)    FUNCTION     ?   CREATE FUNCTION public.delete_cust(_customer_id character varying) RETURNS integer
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
       public          postgres    false            ?            1255    16627    delete_waste(character varying)    FUNCTION     ?   CREATE FUNCTION public.delete_waste(_waste_id character varying) RETURNS integer
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
 @   DROP FUNCTION public.delete_waste(_waste_id character varying);
       public          postgres    false            ?            1255    16624 E   insert_waste(character varying, character varying, character varying)    FUNCTION     }  CREATE FUNCTION public.insert_waste(_waste_type character varying, _waste_price character varying, _waste_unit character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	insert into public.waste
	(
		waste_type, 
		waste_price,
		waste_unit
	)
	values
	(
		_waste_type, 
		_waste_price,
		_waste_unit
	);
	if found then
		return 1;
	else
		return 0;
	end if;
end
$$;
 ?   DROP FUNCTION public.insert_waste(_waste_type character varying, _waste_price character varying, _waste_unit character varying);
       public          postgres    false            ?            1255    16549    select_cust()    FUNCTION     L  CREATE FUNCTION public.select_cust() RETURNS TABLE(_customer_id character varying, _customer_name character varying, _customer_phone character varying, _customer_address character varying)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	select customer_id, customer_name, customer_phone, customer_address from customer;
end
$$;
 $   DROP FUNCTION public.select_cust();
       public          postgres    false            ?            1255    16550    select_record()    FUNCTION     G  CREATE FUNCTION public.select_record() RETURNS TABLE(_record_id character varying, _customer_name character varying, _record_time date, _weight_of_goods real, _total_price real)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	select record_id, customer_name, record_time, weight_of_goods, total_price from records;
end
$$;
 &   DROP FUNCTION public.select_record();
       public          postgres    false            ?            1255    16625    select_waste()    FUNCTION     ,  CREATE FUNCTION public.select_waste() RETURNS TABLE(_waste_id character varying, _waste_type character varying, _waste_price character varying, _waste_unit character varying)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	select waste_id, waste_type, waste_price, waste_unit from waste;
end
$$;
 %   DROP FUNCTION public.select_waste();
       public          postgres    false            ?            1255    16553 B   st_insert(character varying, character varying, character varying)    FUNCTION     ?  CREATE FUNCTION public.st_insert(_customer_name character varying, _customer_phone character varying, _customer_address character varying) RETURNS integer
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
 ?   DROP FUNCTION public.st_insert(_customer_name character varying, _customer_phone character varying, _customer_address character varying);
       public          postgres    false            ?            1255    16554 /   st_insert_record(real, real, character varying)    FUNCTION     ?  CREATE FUNCTION public.st_insert_record(_weight_of_goods real, _total_price real, _customer_name character varying) RETURNS integer
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
       public          postgres    false            ?            1255    16555 5   st_insert_record(date, real, real, character varying)    FUNCTION     ?  CREATE FUNCTION public.st_insert_record(_record_time date, _weight_of_goods real, _total_price real, _customer_name character varying) RETURNS integer
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
 ?   DROP FUNCTION public.st_insert_record(_record_time date, _weight_of_goods real, _total_price real, _customer_name character varying);
       public          postgres    false            ?            1255    16556 B   st_insert_record(character varying, real, real, character varying)    FUNCTION     ?  CREATE FUNCTION public.st_insert_record(_record_time character varying, _weight_of_goods real, _total_price real, _customer_name character varying) RETURNS integer
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
 ?   DROP FUNCTION public.st_insert_record(_record_time character varying, _weight_of_goods real, _total_price real, _customer_name character varying);
       public          postgres    false            ?            1255    16559 U   st_update(character varying, character varying, character varying, character varying)    FUNCTION     ?  CREATE FUNCTION public.st_update(_customer_id character varying, _customer_name character varying, _customer_phone character varying, _customer_address character varying) RETURNS integer
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
 ?   DROP FUNCTION public.st_update(_customer_id character varying, _customer_name character varying, _customer_phone character varying, _customer_address character varying);
       public          postgres    false            ?            1255    16626 X   update_waste(character varying, character varying, character varying, character varying)    FUNCTION     ?  CREATE FUNCTION public.update_waste(_waste_id character varying, _waste_type character varying, _waste_price character varying, _waste_unit character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
	update waste SET
		waste_type=_waste_type,
		waste_price=_waste_price,
		waste_unit = _waste_unit
	WHERE waste_id=_waste_id;
	if found then
		return 1;
	else
		return 0;
	end if;
end
$$;
 ?   DROP FUNCTION public.update_waste(_waste_id character varying, _waste_type character varying, _waste_price character varying, _waste_unit character varying);
       public          postgres    false            ?            1259    16560 
   account_id    SEQUENCE     s   CREATE SEQUENCE public.account_id
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 !   DROP SEQUENCE public.account_id;
       public          postgres    false            ?            1259    16561    account    TABLE     ?   CREATE TABLE public.account (
    account_id character varying(10) DEFAULT ('ST'::text || nextval('public.account_id'::regclass)) NOT NULL,
    account_username character varying(20) NOT NULL,
    account_password character varying(60) NOT NULL
);
    DROP TABLE public.account;
       public         heap    postgres    false    209            ?            1259    16599    admin_id    SEQUENCE     q   CREATE SEQUENCE public.admin_id
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
    DROP SEQUENCE public.admin_id;
       public          postgres    false            ?            1259    16615 	   admin_tbl    TABLE     C  CREATE TABLE public.admin_tbl (
    admin_id character varying(10) DEFAULT ('ST'::text || nextval('public.admin_id'::regclass)) NOT NULL,
    adm_email character varying(50) NOT NULL,
    adm_pass character varying(60) NOT NULL,
    adm_name character varying(100) NOT NULL,
    adm_phone character varying(15) NOT NULL
);
    DROP TABLE public.admin_tbl;
       public         heap    postgres    false    217            ?            1259    16565    customer_id    SEQUENCE     t   CREATE SEQUENCE public.customer_id
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 "   DROP SEQUENCE public.customer_id;
       public          postgres    false            ?            1259    16566    customer    TABLE     -  CREATE TABLE public.customer (
    customer_id character varying(100) DEFAULT ('ST'::text || nextval('public.customer_id'::regclass)) NOT NULL,
    customer_name character varying(50) NOT NULL,
    customer_phone character varying(20) NOT NULL,
    customer_address character varying(255) NOT NULL
);
    DROP TABLE public.customer;
       public         heap    postgres    false    211            ?            1259    16570 	   record_id    SEQUENCE     r   CREATE SEQUENCE public.record_id
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
     DROP SEQUENCE public.record_id;
       public          postgres    false            ?            1259    16571    records    TABLE     -  CREATE TABLE public.records (
    record_id character varying(100) DEFAULT ('ST'::text || nextval('public.record_id'::regclass)) NOT NULL,
    record_time date DEFAULT CURRENT_DATE,
    weight_of_goods real NOT NULL,
    total_price real NOT NULL,
    customer_name character varying(100) NOT NULL
);
    DROP TABLE public.records;
       public         heap    postgres    false    213            ?            1259    16576    waste_id    SEQUENCE     q   CREATE SEQUENCE public.waste_id
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
    DROP SEQUENCE public.waste_id;
       public          postgres    false            ?            1259    16577    waste    TABLE     ?   CREATE TABLE public.waste (
    waste_id character varying(100) DEFAULT ('ST'::text || nextval('public.waste_id'::regclass)) NOT NULL,
    waste_type character varying(100),
    waste_price character varying(30),
    waste_unit character varying(20)
);
    DROP TABLE public.waste;
       public         heap    postgres    false    215                      0    16561    account 
   TABLE DATA           Q   COPY public.account (account_id, account_username, account_password) FROM stdin;
    public          postgres    false    210   ?B       %          0    16615 	   admin_tbl 
   TABLE DATA           W   COPY public.admin_tbl (admin_id, adm_email, adm_pass, adm_name, adm_phone) FROM stdin;
    public          postgres    false    218   ?B                 0    16566    customer 
   TABLE DATA           `   COPY public.customer (customer_id, customer_name, customer_phone, customer_address) FROM stdin;
    public          postgres    false    212   ?C       !          0    16571    records 
   TABLE DATA           f   COPY public.records (record_id, record_time, weight_of_goods, total_price, customer_name) FROM stdin;
    public          postgres    false    214   ?E       #          0    16577    waste 
   TABLE DATA           N   COPY public.waste (waste_id, waste_type, waste_price, waste_unit) FROM stdin;
    public          postgres    false    216   F       ,           0    0 
   account_id    SEQUENCE SET     9   SELECT pg_catalog.setval('public.account_id', 1, false);
          public          postgres    false    209            -           0    0    admin_id    SEQUENCE SET     6   SELECT pg_catalog.setval('public.admin_id', 4, true);
          public          postgres    false    217            .           0    0    customer_id    SEQUENCE SET     :   SELECT pg_catalog.setval('public.customer_id', 14, true);
          public          postgres    false    211            /           0    0 	   record_id    SEQUENCE SET     8   SELECT pg_catalog.setval('public.record_id', 10, true);
          public          postgres    false    213            0           0    0    waste_id    SEQUENCE SET     7   SELECT pg_catalog.setval('public.waste_id', 45, true);
          public          postgres    false    215            ?           2606    16582 $   account account_account_username_key 
   CONSTRAINT     k   ALTER TABLE ONLY public.account
    ADD CONSTRAINT account_account_username_key UNIQUE (account_username);
 N   ALTER TABLE ONLY public.account DROP CONSTRAINT account_account_username_key;
       public            postgres    false    210            ?           2606    16584    account account_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.account
    ADD CONSTRAINT account_pkey PRIMARY KEY (account_id);
 >   ALTER TABLE ONLY public.account DROP CONSTRAINT account_pkey;
       public            postgres    false    210            ?           2606    16622 !   admin_tbl admin_tbl_adm_email_key 
   CONSTRAINT     a   ALTER TABLE ONLY public.admin_tbl
    ADD CONSTRAINT admin_tbl_adm_email_key UNIQUE (adm_email);
 K   ALTER TABLE ONLY public.admin_tbl DROP CONSTRAINT admin_tbl_adm_email_key;
       public            postgres    false    218            ?           2606    16620    admin_tbl admin_tbl_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.admin_tbl
    ADD CONSTRAINT admin_tbl_pkey PRIMARY KEY (admin_id);
 B   ALTER TABLE ONLY public.admin_tbl DROP CONSTRAINT admin_tbl_pkey;
       public            postgres    false    218            ?           2606    16586    customer customer_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.customer
    ADD CONSTRAINT customer_pkey PRIMARY KEY (customer_id);
 @   ALTER TABLE ONLY public.customer DROP CONSTRAINT customer_pkey;
       public            postgres    false    212            ?           2606    16588    records records_pkey 
   CONSTRAINT     Y   ALTER TABLE ONLY public.records
    ADD CONSTRAINT records_pkey PRIMARY KEY (record_id);
 >   ALTER TABLE ONLY public.records DROP CONSTRAINT records_pkey;
       public            postgres    false    214            ?           2606    16590    waste waste_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.waste
    ADD CONSTRAINT waste_pkey PRIMARY KEY (waste_id);
 :   ALTER TABLE ONLY public.waste DROP CONSTRAINT waste_pkey;
       public            postgres    false    216                  x?????? ? ?      %   ?   x?M???0F?ۧ??e?M7#D???T?[S??^0??9??j		]?Y??Ó??.o???1???g??&?WV(??R?eΪZA?w.????&5??????????m?)?)?T?????}C????'?a??^?????_H???ưc??=?         ?  x?5?Kn?0E??*????PnQvSv?Q&ϕ 3????
?????{Ϝ??BC?M?ka?kc???XC?p?????6.???,?Bz?!?-??h?? ??[bG??????ϩ??)R7???????Iˬ?$+?飫?V???ܖ?
I-?k????č?JzϽd??S???o獑C0@O?Cjļ0a?6?qF?C?h?k??)n??1K??	???y,???I???A]??e?6Ns??#'X,?4????Y??c?XI??????ta<A?y???ZY˥r?cP?!?~??O??w?0@?0??{?$Ӟ???S?/?c:?u?xI	??怭?m??%?Ns?????U??H???;.??
???Q?Qr
??0~????2ǎa??t??+?y???^j?ȡ+??e?Lx??]y*??k?&zZ?2?sN;??-?\6?u\!}???[????ޮ?S      !   ?   x?m?A
?0????S?)3?im.?ʕ??MD?@???L?g???&?eU'??C??p???9????P?O?j?U^?q(?ձ9????{???le?n?פ|?6??9???&?iM?<ѥ%?'?w;      #   ?  x?mR???0<??????p???(3???ԋ??I?c???з???????ѮV+ko?<??π??#:&?7?:???-?????)??։?,e?U?^?Oت??? <*h???J?^?ظK?????Y??.B?BɞdJ{?????'????'??$?PZ8?٤?T?T??!?+?d`>?­????E?]-h?d?+?!oR??#>q?????U?=BU?n?cPA???Y!;z:?????X??EZm??W????^?
?3?5?TW??#G???)?`
??p??2????????ҭ?????????^?,??.??)V?N9?J?}??e?訊??!?Ì8SW?:R:a?X???i{?~?^?????{v?AѦ?8H???y?1??G?6?;??2????Jy???0v?Q6}??ª2?f??:??*??@?t????`EQ?\;R??????_6??o@"P     