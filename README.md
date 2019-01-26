# Install:

## Get The Requirements

1. Get Git: https://git-scm.com/downloads
2. Get .NET Core 2.2 SDK: https://www.microsoft.com/net/download
  
## Get and build this software from source code

```sh
git clone https://github.com/nopara73/WasabiEncryptedSecretTester.git
cd WasabiEncryptedSecretTester/WasabiEncryptedSecretTester
dotnet restore
dotnet build

```

## Usage

Issue `dotnet run {encryptedSecret} {password}` from the ` WasabiEncryptedSecretTester/WasabiEncryptedSecretTester` folder. And the software will tell you if the password is correct or not.
You can find your encryptedSecret in your `Wallet.json` file, that you have previously created with Wasabi.