**Table of contents**
- [Google Drive API v3](#google-drive-api-v3)
  - [How to enable it?](#how-to-enable-it)
  - [Getting client_secret.json](#getting-client_secretjson)
- [IMPORTANT](#important)
- [Set/Reset token](#setreset-token)

# [Google Drive API v3](https://developers.google.com/drive/api/v3/reference)
This API allows you to manage your Google Drive within a C# application. Among all the features you can do with this API, this app uses it to **create**, **enable link sharing** and **selecting files** within a Google Drive account.

## How to enable it?
You should go to [this link](https://console.developers.google.com/start/api?id=drive) and choose the Google account you want to use for using its Google Drive. Then accept the terms of service and click on agree and create a new project, and click on next.

![image](https://user-images.githubusercontent.com/57675992/143512159-59c84a27-3584-42dc-a6fa-462ceea9977b.png)

Then, the API must be enabled

![image](https://user-images.githubusercontent.com/57675992/143512239-f2df8deb-f221-413c-832a-fa8497e89dfb.png)

After API is successfully enabled, go to the side menu and go to credentials.

![image](https://user-images.githubusercontent.com/57675992/143512365-df029708-2b90-4e4a-9837-2a5ad0013032.png)

Afterwards you need to create the OAuth consent screen.

![cred-oauth](https://lh3.googleusercontent.com/pw/ACtC-3czwdvhKOCsNJRjhXKr9Y1rnzk9HJ7YY4bSxT5hz116h9ZAPhblnEwlvjSZ8QxEbi74aVvFLedzLVYfhTux4GJMUJgxpds-GulWcWLiNtlFpQlK80YWVW6cH9kzY7sxftH8n5ZZyo_Yv5pH0LhcoTk=w1079-h606-no?authuser=2)

It should be an external user type OAuth credential.

![create-oauh](https://lh3.googleusercontent.com/pw/ACtC-3cEPhii_caXgqhDWHEDg8F3UAOK8n0jnkiH76xNKDfyerD4UUjkusWKHCoxypIMNP6znXaB_CkgOfzRaUExkW7qhJ2GlFM9hGBrgQH7O38xZ6M0Xhmrh9gnrm93vJnAvVfQaeJ5Y4ytKcuUvINoO9E=w1077-h552-no?authuser=2)

And in the next window you should place the following information.

![info-oauth!](https://lh3.googleusercontent.com/pw/ACtC-3e8rGdjIsXBzxLzRAm48XSGqJvctcR1SLFQ11QbFFqkUa36WNLT-rdg6dTiHikEsVKb0s2CHlu7Zm1S_VZ877fOnbiluLn0dCuwF2b-srV2VcDem8L4IJ1zO-T_BdSNXLK6tvyAdoMUWnzVriqPG9I=w1079-h1493-no?authuser=2)

And you will need to save and continue with the following information.

![oauth1!](https://lh3.googleusercontent.com/pw/ACtC-3dnBqa4gD8XK5K1g0N82DPUPXZMC1RHFwIbfUMUaq5YNpOh30hFmS4JPgOQ5yr7vqO2QPgu2slIq9SB0ix4GXkVyQxrkPOV7gDsDh-IfstVLxSRT5PpxDDFymG_NstfRf84YF3Zn1JVxGSHHd_DJ8s=w757-h815-no?authuser=2)

For Test *Users*

![oauth3!](https://lh3.googleusercontent.com/pw/ACtC-3enMDWUIfBkDGLe_Vt_lpfgWfhk0y1XIxNnxK5Jg_QTPzt_9V1j_0i7lDERORJjQkW-KA9QsdsrT91KIuFdZqrt1NoXi_Dj-i7MWQF1dPQj5QsFfspkFlAzQZE1HM9ZHVsBrmRPM1U4hmzGrKTKDlc=w746-h596-no?authuser=2)

And finally for *Summary*

![oauth4!](https://lh3.googleusercontent.com/pw/ACtC-3fUhUaHbIb11b-EkFwhxZ2b1Petxhg1ohTMpPaAEt0FqFcpfUG6nRNVsCnJKWtpLtiQ27cYL1hQSpcyOOJOL5Py5BuJyCmgPUPDCJsEUJmYlSqAhaBOdOiz9aTMwkgl5u2l50OYz6ei3wYuBOgvuC4=w749-h1427-no?authuser=2)

## Getting client_secret.json
After doing all the steps, you need to create the **OAuth client ID**.

![create-oauthid!](https://lh3.googleusercontent.com/pw/ACtC-3cxx8hi3mTBn_K0tB5HIP3_o5bZbqMFUnBELgKgh6pPvUVnwImqusj-HCB-zSl30vwd23T54KPehvGo4IEb-ccXpBWjVrqLzNK43GXmWRYHbTVhJuL_QUr1JrcGwCp88ZOoL2NfaQxNLkRlqOf0TIY=w1078-h531-no?authuser=2)

Then the credantial should be created like it's shown in the image below

![create-oauthid2!](https://lh3.googleusercontent.com/pw/ACtC-3cN4Y4Yz7eOCDCCim_-aI06fFpmktUPmO6m0zCP2QHpn0ofuGayfx28kZr6B6eAkchsuFkhY7uceCZXub3inphB_IwR2vRye-sUshc1TiuvU5A5bPRCWtd6hPnMh_cXq1zDAgbmxQWq_DK251selms=w649-h408-no?authuser=2)

# IMPORTANT

After this, you can download your **client_secret.json**. **It will have another name, BUT YOU SHOULD RENAME IT AS** "client_secret.json" **and save it** in this directory: `evaseac\app\Evaseac\bin\Debug\`

![download-oauth!](https://lh3.googleusercontent.com/pw/ACtC-3cn0EAIEk4UxfduUpDcsSz4OLe9r-skeo_zvx5t07F2lweEfpsd3VH8PsfEfQ0CLF1LHgl9SKUjMaMaQCzg1TmJWvugM47ETNpgw6LSJi_O4PTG2Rzl7pkJfl5YvH9F1TyhvSilCN3CI-k9XPqEApI=w1080-h578-no?authuser=2)

The developer's email is the only one that can use the APP, so test users should be added.

![image](https://user-images.githubusercontent.com/57675992/143514856-f88e2a34-c65b-4629-98e1-e19de4a6df37.png)


# Set/Reset token
If you would want to reset your GDAPIv3 genereted token while debugging, you should go to the following directory: `evaseac\app\Evaseac\bin\Debug\` and in there you should delete the `token.json` and `client_secret.json` and save the newer `client_secret.json` there for debugging.

After this when you click in everything related to GDAPIv3, the explorer will ask for your permission in order to use the API we just created.

![permission!](https://lh3.googleusercontent.com/pw/ACtC-3ewdvIUk01YiEWmUD5B1U0Wp2lkh_XE0KYQwSsa0gq-KdvXlKBvgA1ZeUKbmzF6xhkQ9xuBFAv6GyhjctEx4qITnAbJuOAL5aM4sdVxWaU_N-TipunIP0Bon_nvIV8lrqfrp3_Fsr-U_lUzQtU2ftE=w489-h525-no?authuser=2)
