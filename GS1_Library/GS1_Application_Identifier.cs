﻿public static class GS1_APPID
{

    /*
        * n implied decimal point position
        * N numeric digit
        * X any character in figure 7.11-1 for GS1 AI encodable character set 82
        * Y any character in figure 7.11-2 for GS1 AI encodable character set 39
        * Z any character in figure 7.11-3 for GS1 AI encodable character set 64 (file-safe / URI-safe base64)
        * N3 3 numeric digits, fixed length
        * X3 3 characters, fixed length
        * N..3 up to 3 numeric digits
        * X..3 up to 3 characters in figure 7.11-1 for GS1 AI encodable character set 82
        * Y..3 up to 3 characters in figure 7.11-2 for GS1 AI encodable character set 39
        * Z..3 up to 3 characters in figure 7.11-3 for GS1 AI encodable character set 64 (file-safe / URI-safe base64)
        * [ ] enclosed value is an optional componen
     */

    public static const string SSCC                         = "00"  ; //Format: N2+N18                  (Identification of a logicstic unit)
    public static const string GTIN                         = "01"  ; //Format: N2+N14                  (Identification of a trade item)
    public static const string CONTENT                      = "02"  ; //Format: N2+N14                  (Idenfification of trade items contained in a logistic unit)
    public static const string BATCH_LOT                    = "10"  ; //Format: N2+X..20       (FNC1)   (Batch or lot number)
    public static const string PROD_DATE                    = "11"  ; //Format: N2+N6                   (Production date)
    public static const string DUE_DATE                     = "12"  ; //Format: N2+N6                   (Due date for amount on payment slip)
    public static const string PACK_DATE                    = "13"  ; //Format: N2+N6                   (Packaging date)
    public static const string BEST_BEFORE_BY               = "15"  ; //Format: N2+N6                   (Best before date)
    public static const string SELL_BY                      = "16"  ; //Format: N2+N6                   (Sell by date)
    public static const string USE_BY_EXPIRY                = "17"  ; //Format: N2+N6                   (Expiration date)
    public static const string VARIANT                      = "20"  ; //Format: N2+N2                   (Internal product variant)
    public static const string SERIAL                       = "21"  ; //Format: N2+X..20       (FNC1)   (Serial number)
    public static const string CPV                          = "22"  ; //Format: N2+X..20       (FNC1)   (Consumer product variant)
    public static const string TPX                          = "235" ; //Format: N3+X..28       (FNC1)   (Third party controlled, serialized extension of GTIN)
    public static const string ADDITIONAL_ID                = "240" ; //Format: N3+X..30       (FNC1)   (Additional product identification assigned by the manufacturer)
    public static const string CUSTOMER_PART_NO             = "241" ; //Format: N3+X..30       (FNC1)   (Customer part number)
    public static const string MTO_VARIANT                  = "242" ; //Format: N3+N..6        (FNC1)   (Made-to-order variation number)
    public static const string PCN                          = "243" ; //Format: N3+X..20       (FNC1)   (Packaging component number)
    public static const string SECONDARY_SERIAL             = "250" ; //Format: N3+X..30       (FNC1)   (Secondary serial number)
    public static const string REF_TO_SOURCE                = "251" ; //Format: N3+X..30       (FNC1)   (Reference to source entity)
    public static const string GDTI                         = "253" ; //Format: N3+N13[+X..17] (FNC1)   (Global document type identifier)
    public static const string GLN_EXTENSION_COMPONENT      = "254" ; //Format: N3+X..20       (FNC1)   (Global location number extension component)
    public static const string GCN                          = "255" ; //Format: N3+N13[+N..12] (FNC1)   (Global coupon number)
    public static const string VAR_COUNT                    = "30"  ; //Format: N2+N..8        (FNC1)   (Variable count of items)
    public static const string NET_WEIGHT_KG                = "310n"; //Format: N4+N6                   (Net weight - kilograms - variable measure trade item)
    public static const string LENGTH_M                     = "311n"; //Format: N4+N6                   (Length or first dimension - metres - variable measure trade item)
    public static const string WIDTH_M                      = "312n"; //Format: N4+N6                   (Width or second dimension - metres - variable measure trade item)
    public static const string HEIGHT_M                     = "313n"; //Format: N4+N6                   (Depth, thickness, height or third dimension - metres - variable measure trade item)
    public static const string AREA_M2                      = "314n"; //Format: N4+N6                   (Area - square metres - variable measure trade item)
    public static const string NET_VOLUME_L                 = "315n"; //Format: N4+N6                   (Net volume - litres - variable measure trade item)
    public static const string NET_VOLUME_M3                = "316n"; //Format: N4+N6                   (Net volume - cubic metres - variable measure trade item)
    public static const string NET_WEIGHT_LB                = "320n"; //Format: N4+N6                   (Net wieght - pounds - variable measure trade item)
    public static const string LENGTH_IN                    = "321n"; //Format: N4+N6                   (Length or first dimension - inches - variable measure trade item)
    public static const string LENGTH_FT                    = "322n"; //Format: N4+N6                   (Length or first dimension - feet - variable measure trade item)
    public static const string LENGTH_YD                    = "323n"; //Format: N4+N6                   (Length or first dimension - yards - variable measure trade item)
    public static const string WIDTH_IN                     = "324n"; //Format: N4+N6                   (Width, diameter or second dimension - inches - variable measure trade item)
    public static const string WIDTH_FT                     = "325n"; //Format: N4+N6                   (Width, diameter or second dimension - feet - variable measure trade item)
    public static const string WIDTH_YD                     = "326n"; //Format: N4+N6                   (Width, diameter or second dimension - yards - variable measure trade item)
    public static const string HEIGHT_IN                    = "327n"; //Format: N4+N6                   (Depth, thickness, height or third dimension - inches - variable measure trade item)
    public static const string HEIGHT_FT                    = "328n"; //Format: N4+N6                   (Depth, thickness, height or third dimension - feet - variable measure trade item)
    public static const string HEIGHT_YD                    = "329n"; //Format: N4+N6                   (Depth, thickness, height or third dimension - yards - variable measure trade item)
    public static const string GROSS_WEIGHT_KG              = "330n"; //Format: N4+N6                   (Logistic weight - kilograms)
    public static const string LENGTH_M_LOG                 = "331n"; //Format: N4+N6                   (Length or first dimension - metres)
    public static const string WIDTH_M_LOG                  = "332n"; //Format: N4+N6                   (Width, diameter or second dimension - metres)
    public static const string HEIGHT_M_LOG                 = "333n"; //Format: N4+N6                   (Depth, thickness, height or third dimension - metres)
    public static const string AREA_M2_LOG                  = "334n"; //Format: N4+N6                   (Area - square metres)
    public static const string VOLUME_L_LOG                 = "335n"; //Format: N4+N6                   (Logistic volume - litres)
    public static const string VOLUME_M3_LOG                = "336n"; //Format: N4+N6                   (Logistic volume - cubic metres)
    public static const string KG_PER_M2                    = "337n"; //Format: N4+N6                   (Kilograms per square metre)
    public static const string GROSS_WEIGHT_LB              = "340n"; //Format: N4+N6                   (Logistic weight - pounds)
    public static const string LENGTH_IN_LOG                = "341n"; //Format: N4+N6                   (Length or first dimension - inches)
    public static const string LENGTH_FT_LOG                = "342n"; //Format: N4+N6                   (Length or first dimension - feet)
    public static const string LENGTH_YD_LOG                = "343n"; //Format: N4+N6                   (Length or first dimension - yards)
    public static const string WIDTH_IN_LOG                 = "344n"; //Format: N4+N6                   (Width, diameter or second dimension - inches)
    public static const string WIDTH_FT_LOG                 = "345n"; //Format: N4+N6                   (Width, diameter or second dimension - feet)
    public static const string WIDTH_YD_LOG                 = "346n"; //Format: N4+N6                   (Width, diameter or second dimension - yards)
    public static const string HEIGHT_IN_LOG                = "347n"; //Format: N4+N6                   (Depth, thickness, height or thid dimmension - inches)
    public static const string HEIGHT_FT_LOG                = "348n"; //Format: N4+N6                   (Depth, thickness, height or thid dimmension - feet)
    public static const string HEIGHT_YD_LOG                = "349n"; //Format: N4+N6                   (Depth, thickness, height or thid dimmension - yards)
    public static const string AREA_IN2                     = "350n"; //Format: N4+N6                   (Area - square inches - variable measure trade item)
    public static const string AREA_FT2                     = "351n"; //Format: N4+N6                   (Area - square feet - variable measure trade item)
    public static const string AREA_YD2                     = "352n"; //Format: N4+N6                   (Area - square yards - variable measure trade item)
    public static const string AREA_IN2_LOG                 = "353n"; //Format: N4+N6                   (Area - square inches)
    public static const string AREA_FT2_LOG                 = "354n"; //Format: N4+N6                   (Area - square feet)
    public static const string AREA_YD2_LOG                 = "355n"; //Format: N4+N6                   (Area - square yards)
    public static const string NET_WEIGHT_T                 = "356n"; //Format: N4+N6                   (Net weight - troy ounces - variable measure trade item)
    public static const string NET_VOL_OZ                   = "357n"; //Format: N4+N6                   (Net weight or volume - ounces - variable measure trade item)
    public static const string NET_VOL_Q                    = "360n"; //Format: N4+N6                   (Net volume - quarts - variable measure trade item)
    public static const string NET_VOL_G                    = "361n"; //Format: N4+N6                   (Net volume - gallons - variable measure trade item)
    public static const string NET_VOL_Q_LOG                = "362n"; //Format: N4+N6                   (Logistic volume - quarts)
    public static const string NET_VOL_G_LOG                = "363n"; //Format: N4+N6                   (Logistic volume - gallons)
    public static const string VOLUME_IN3                   = "364n"; //Format: N4+N6                   (Net volume - cubic inches - variable measure trade item)
    public static const string VOLUME_FT3                   = "365n"; //Format: N4+N6                   (Net volume - cubic feet - variable measure trade item)
    public static const string VOLUME_YD3                   = "366n"; //Format: N4+N6                   (Net volume - cubic yards - variable measure trade item)
    public static const string VOLUME_IN3_LOG               = "367n"; //Format: N4+N6                   (Logistic volume - cubic inches)
    public static const string VOLUME_FT3_LOG               = "368n"; //Format: N4+N6                   (Logistic volume - cubic feet)
    public static const string VOLUME_YD3_LOG               = "369n"; //Format: N4+N6                   (Logistic volume - cubic yards)
    public static const string COUNT                        = "37"  ; //Format: N2+N..8        (FNC1)   (Count of trade items or trade item pieces contained in a logistic unit)
    public static const string AMOUNT_PAY_COUPON_VAL        = "390n"; //Format: N4+N..15       (FNC1)   (Amount payable or coupon value - single monetary area)
    public static const string AMOUNT_PAY_ISO_CURR_CODE     = "391n"; //Format: N4+N3+N..15    (FNC1)   (Amount payable and ISO currency code)
    public static const string PRICE_SIN_MON_AREA           = "392n"; //Format: N4+N..15       (FNC1)   (Amount payable for a variable measure trade item - single monetary area)
    public static const string PRICE_ISO_CURR_CODE          = "393n"; //Format: N4+N3+N..15    (FNC1)   (Amount payable for a variable measure trade item and ISO currency code)
    public static const string PERCENT_OFF                  = "394n"; //Format: N4+N4          (FNC1)   (Percentage discount of a coupon)
    public static const string PRICE_UOM                    = "395n"; //Format: N4+N6          (FNC1)   (Amount payable per unit of measure - single monetary area)
    public static const string ORDER_NUMBER                 = "400" ; //Format: N3+X..30       (FNC1)   (Customers purchase order number)
    public static const string GINC                         = "401" ; //Format: N3+X..30       (FNC1)   (Global identification number for cosignment)
    public static const string GSIN                         = "402" ; //Format: N3+N17         (FNC1)   (Global shipment identification number)
    public static const string ROUTE                        = "403" ; //Format: N3+X..30       (FNC1)   (Routing code)
    public static const string SHIP_TO_LOC                  = "410" ; //Format: N3+N13                  (Ship to - deliver to global location number)
    public static const string BILL_TO                      = "411"; //Format: N3+N13                   (Bill to - deliver to global location number)
    public static const string PURCHASE_FROM                = "412" ; //Format: N3+N13                  (Purchased from global location number)
    public static const string SHIP_FOR_LOC                 = "413" ; //Format: N3+N13                  (Ship for - deliver for - forward to global location number)
    public static const string LOC_NO                       = "414" ; //Format: N3+N13                  (Identification  of a physical location - global location number)
    public static const string PAY_TO                       = "415" ; //Format: N3+N13                  (Global location number of the invoicing party)
    public static const string PROD_SERV_LOC                = "416" ; //Format: N3+N13                  (Global loctaion number of the proudction or service location)
    public static const string PARTY                        = "417" ; //Format: N3+N13                  (Party global location number)
    public static const string SHIP_TO_POST_SINGLE_POSTAL   = "420" ; //Format: N3+X..20       (FNC1)   (Ship to - deliver to postal code within a single postal authority)
    public static const string SHIP_TO_POST_ISO_COUNTRY     = "421" ; //Format: N3+N3+X..9     (FNC1)   (Ship to - deliver to postal code with three-digit ISO country code)
    public static const string ORIGIN                       = "422" ; //Format: N3+N3          (FNC1)   (Country of origin of a trade item)
    public static const string COUNTRY_INITIAL_PROCESS      = "423" ; //Format: N3+N3+N..12    (FNC1)   (Country of initial processing)
    public static const string COUNTRY_PROCESS              = "424" ; //Format: N3+N3          (FNC1)   (Country of processing)
    public static const string COUNTRY_DISASSEMBLY          = "425" ; //Format: N3+N3+N..12    (FNC1)   (Country of disassembly)
    public static const string COUNTRY_FULL_PROCESS         = "426" ; //Format: N3+N3          (FNC1)   (Country covering full process of chain)
    public static const string ORIGIN_SUBDIVISION           = "427" ; //Format: N3+X..3        (FNC1)   (Country subdivision of origin code for a trade item)
    public static const string SHIP_TO_COMP                 = "4300"; //Format: N4+X..35       (FNC1)   (Ship to - deliver to company name)
    public static const string SHIP_TO_NAME                 = "4301"; //Format: N4+X..35       (FNC1)   (Ship to - deliver to contact name)
    public static const string SHIP_TO_ADD1                 = "4302"; //Format: N4+X..70       (FNC1)   (Ship to - deliver to address line 1)
    public static const string SHIP_TO_ADD2                 = "4303"; //Format: N4+X..70       (FNC1)   (Ship to - deliver to address line 2)
    public static const string SHIP_TO_SUB                  = "4304"; //Format: N4+X..70       (FNC1)   (Ship to - deliver to suburb)
    public static const string SHIP_TO_LOC                  = "4305"; //Format: N4+X..70       (FNC1)   (Ship to - deliver to locality)
    public static const string SHIP_TO_REG                  = "4306"; //Format: N4+X..70       (FNC1)   (Ship to - deliver to region)
    public static const string SHIP_TO_COUNTRY              = "4307"; //Format: N4+X2          (FNC1)   (Ship to - deliver to coutnry code)
    public static const string SHIP_TO_PHONE                = "4308"; //Format: N4+X..30       (FNC1)   (Ship to - deliver to telephone number)
    public static const string SHIP_TO_GEO                  = "4309"; //Format: N4+N20         (FNC1)   (Ship to - deliver to GEO location)
    public static const string RTN_TO_COMP                  = "4310"; //Format: N4+X..35       (FNC1)   (Return to - company name)
    public static const string RTN_TO_NAME                  = "4311"; //Format: N4+X..35       (FNC1)   (Return to - contact name)
    public static const string RTN_TO_ADD1                  = "4312"; //Format: N4+X..70       (FNC1)   (Return to - address line 1)
    public static const string RTN_TO_ADD2                  = "4313"; //Format: N4+X..70       (FNC1)   (Return to - address line 2)
    public static const string RTN_TO_SUB                   = "4314"; //Format: N4+X..70       (FNC1)   (Return to - suburb)
    public static const string RTN_TO_LOG                   = "4315"; //Format: N4+X..70       (FNC1)   (Return to - locality)
    public static const string RTN_TO_REG                   = "4316"; //Format: N4+X..70       (FNC1)   (Return to - region)
    public static const string RTN_TO_COUNTRY               = "4317"; //Format: N4+X2          (FNC1)   (Return to - country code)
    public static const string RTN_TO_POST                  = "4318"; //Format: N4+X..20       (FNC1)   (Return to - postal code)
    public static const string RTN_TO_PHONE                 = "4319"; //Format: N4+X..30       (FNC1)   (Return to - telephone number)
    public static const string SRV_DESCRIPTION              = "4320"; //Format: N4+X..35       (FNC1)   (Service code description)
    public static const string DANGEROUS_GOODS              = "4321"; //Format: N4+N1          (FNC1)   (Dangerous goods flag)
    public static const string AUTH_LEAVE                   = "4322"; //Format: N4+N1          (FNC1)   (Authority to leave flag)
    public static const string SIG_REQUIRED                 = "4323"; //Format: N4+N1          (FNC1)   (Signature required flag)
    public static const string NBEF_DEL_DT                  = "4324"; //Format: N4+N10         (FNC1)   (Not before delivery date/time)
    public static const string NAFT_DEL_DT                  = "4325"; //Format: N4+N10         (FNC1)   (Not after delivery date/time)
    public static const string REL_DATE                     = "4326"; //Format: N4+N6          (FNC1)   (Release date)
    public static const string MAX_TEMP_F                   = "4330"; //Format: N4+N6+[-]      (FNC1)   (Maximum temperature in farenheight)
    public static const string MAX_TEMP_C                   = "4331"; //Format: N4+N6+[-]      (FNC1)   (Maximum temperature in celsius)
    public static const string MIN_TEMP_F                   = "4332"; //Format: N4+N6+[-]      (FNC1)   (Minimum temperature in farenheight)
    public static const string MIN_TEMP_C                   = "4333"; //Format: N4+N6+[-]      (FNC1)   (Minimum temperature in celsius)
    public static const string NSN                          = "7001"; //Format: N4+N13         (FNC1)   (Nato stock number)
    public static const string MEAT_CUT                     = "7002"; //Format: N4+X..30       (FNC1)   (UNECE meat carcasses and cuts classification)
    public static const string EXPIRY_TIME                  = "7003"; //Format: N4+N10         (FNC1)   (Expiration date and time)
    public static const string ACTIVE_POTENCY               = "7004"; //Format: N4+N..4        (FNC1)   (Active potency)
    public static const string CATCH_AREA                   = "7005"; //Format: N4+X..12       (FNC1)   (Catch area)
    public static const string FIRST_FREEZE_DATE            = "7006"; //Format: N4+N6          (FNC1)   (First freeze date)
    public static const string HARVEST_DATE                 = "7007"; //Format: N4+N6[+N6]     (FNC1)   (Harvest date)
    public static const string AQUATIC_SPECIES              = "7008"; //Format: N4+X..3        (FNC1)   (Species for fishery purposes)
    public static const string FISHING_GEAR_TYPE            = "7009"; //Format: N4+X..10       (FNC1)   (Fishing gear type)
    public static const string PROD_METHOD                  = "7010"; //Format: N4+X..2        (FNC1)   (Production method)
    public static const string TEST_BY_DATE                 = "7011"; //Format: N4+N6[+N4]     (FNC1)   (Test by date)
    public static const string REFURB_LOT                   = "7020"; //Format: N4+X..20       (FNC1)   (Refurbishment lot ID)
    public static const string FUNC_STAT                    = "7021"; //Format: N4+X..20       (FNC1)   (Functional status)
    public static const string REV_STATUS                   = "7022"; //Format: N4+X..20       (FNC1)   (Revision status)
    public static const string GIAI_ASSEMBLY                = "7023"; //Format: N4+X..30       (FNC1)   (Global inidivual asset identifier of an assembly)
    public static const string PROCESSOR_NO                 = "703s"; //Format: N4+N3+X..27    (FNC1)   (Number of processor with three digit ISO country code)
    public static const string UIC_EXT                      = "7040"; //Format: N4+N1+X3       (FNC1)   (GSI UIC with extension 1 and imported index)
    public static const string NHRN_PZN                     = "710" ; //Format: N3+X..20       (FNC1)   (National-healthcare reimbursement number - Germany PZN)
    public static const string NHRN_CIP                     = "711" ; //Format: N3+X..20       (FNC1)   (National-healthcare reimbursement number - France CIP)
    public static const string NHRN_CN                      = "712" ; //Format: N3+X..20       (FNC1)   (National-healthcare reimbursement number - Spain CN)
    public static const string NHRN_DRN                     = "713" ; //Format: N3+X..20       (FNC1)   (National-healthcare reimbursement number - Brazil DRN)
    public static const string NHRN_AIM                     = "714" ; //Format: N3+X..20       (FNC1)   (National-healthcare reimbursement number - Portugal AIM)
    public static const string NHRN_NDC                     = "715" ; //Format: N3+X..20       (FNC1)   (National-healthcare reimbursement number - United States of America NDC)
    public static const string CERT_NO                      = "723s"; //Format: N4+X2+X..28    (FNC1)   (Certification reference)
    public static const string PROTOCOL                     = "7240"; //Format: N4+X..20       (FNC1)   (Protocol ID)
    public static const string AIDC_MEDIA_TYPE              = "7241"; //Format: N4+N2          (FNC1)   (AIDC media type)
    public static const string VCN                          = "7242"; //Format: N4+X…25        (FNC1)   (Version control number)
    public static const string DIMMENSIONS                  = "8001"; //Format: N4+N14         (FNC1)   (Roll products - width, length, core diamater, direction ,splices)
    public static const string CMT_NO                       = "8002"; //Format: N4+X..20       (FNC1)   (Cellular mobile telephone identifier)
    public static const string GRAI                         = "8003"; //Format: N4+N14[+X..16] (FNC1)   (Global returnable asset iddentifier)
    public static const string GIAI                         = "8004"; //Format: N4+X..30       (FNC1)   (Global individual asset identifier)
    public static const string PRICE_PER_UNIT               = "8005"; //Format: N4+N6          (FNC1)   (Price per unit of measure)
    public static const string ITIP                         = "8006"; //Format: N4+N14+N2+N2   (FNC1)   (Identification of an individual trade item)
    public static const string IBAN                         = "8007"; //Format: N4+X..34       (FNC1)   (International bank account number)
    public static const string PROD_TIME                    = "8008"; //Format: N4+N8[+N..4]   (FNC1)   (Date and time of production)
    public static const string OPTSEN                       = "8009"; //Format: N4+X..50       (FNC1)   (Optically readable sensor indicator)
    public static const string CPID                         = "8010"; //Format: N4+Y..30       (FNC1)   (Component/part identifier)
    public static const string CPID_SERIAL                  = "8011"; //Format: N4+N..12       (FNC1)   (Component/part identifier serial number)
    public static const string VERSION                      = "8012"; //Format: N4+X..20       (FNC1)   (Software version)
    public static const string GMN                          = "8013"; //Format: N4+X..25       (FNC1)   (Global module number)
    public static const string GSRN_PROVIDER                = "8017"; //Format: N4+N18         (FNC1)   (Global service relation number to identify the relationship between an organization offering services and the prodivder of services)
    public static const string GSRN_RECIPIENT               = "8018"; //Format: N4+N18         (FNC1)   (Global service relation number to identify the relationship between an organization offering services and the recipient of services)
    public static const string SRIN                         = "8019"; //Format: N4+N..10       (FNC1)   (Service relation instance number )
    public static const string REF_NO                       = "8020"; //Format: N4+X..25       (FNC1)   (Payment slip reference number)
    public static const string ITIP_CONTENT                 = "8026"; //Format: N4+N14+N2+N2   (FNC1)   (Identification of pieces of a trade item contained in a logistic unit)
    public static const string DIGSIG                       = "8030"; //Format: N4+Z..90       (FNC1)   (Digital signature)
    public static const string COUPON_CODE_NA               = "8110"; //Format: N4+X..70       (FNC1)   (Coupon code identification for use in North America)
    public static const string POINTS                       = "8111"; //Format: N4+N4          (FNC1)   (Loyalty points of a coupon)
    public static const string POFCPID_NA                   = "8112"; //Format: N4+X..70       (FNC1)   (Positive offer file coupon code identification for use in North America)
    public static const string PRODUCT_URL                  = "8200"; //Format: N4+X..70       (FNC1)   (Extended packaging URL)
    public static const string INTERNAL_INFO_MU_AGREED      = "90"  ; //Format: N2+X..30       (FNC1)   (Information mutually agreed between trading partners)
    public static const string INTENRAL_91                  = "91"  ; //Format: N2+X..90       (FNC1)   (Company internal information)
    public static const string INTENRAL_92                  = "92"  ; //Format: N2+X..90       (FNC1)   (Company internal information)
    public static const string INTENRAL_93                  = "93"  ; //Format: N2+X..90       (FNC1)   (Company internal information)
    public static const string INTENRAL_94                  = "94"  ; //Format: N2+X..90       (FNC1)   (Company internal information)
    public static const string INTENRAL_95                  = "95"  ; //Format: N2+X..90       (FNC1)   (Company internal information)
    public static const string INTENRAL_96                  = "96"  ; //Format: N2+X..90       (FNC1)   (Company internal information)
    public static const string INTENRAL_97                  = "97"  ; //Format: N2+X..90       (FNC1)   (Company internal information)
    public static const string INTENRAL_98                  = "98"  ; //Format: N2+X..90       (FNC1)   (Company internal information)
    public static const string INTENRAL_99                  = "99"  ; //Format: N2+X..90       (FNC1)   (Company internal information)
}
