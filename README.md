## ShootingStar VRセットアップ&運用マニュアル

* 必要なもの
  * PC 
  * Oculus Go
  * Unity(version 2018.2.2f1)   
  
* 準備手順  
1. Unityのダウンロードとアカウント登録  
2. Oculus Goの開発者モードの設定およびPCへの接続
3. ゲームのプロジェクトのダウンロード  
4. JDK(Java Development Kit)とSDKのダウンロード
5. Oculus Goでゲームの起動するまでの手順  
6. 遊び方
## 1. Unityのダウンロードとアカウント登録
### 1-1. Unityのダウンロード
「<https://unity3d.com/jp/get-unity/download>」左記のURLページのリソース欄にある過去のバージョンのUnityをクリックしてダウンロードページに移動。「Unity2018.x」を選択し一覧にある「Unity2018.2.2」の「ダウンロード(Win)→Unityインストーラー」をクリックしてダウンロードする。  
### 1-2. Unityのインストール  
ダウンロードしたファイルを実行してUnityをインストール。
### 1-3. Unityアカウントの作成  
インストール終了後、Unityを起動する。ログイン画面に移動するので「create one」をクリックしてアカウントを作成する。すでにアカウントを持っている場合は新しく作成する必要はない。
### 1-4. Unityにログイン  
アカウント作成後、ログインするとLicenseManagement選択画面が表示されるのでPersonalを選択して次に進むとProjects選択画面に移動する。  
## 2. Oculus Goの開発者モードの設定およびPCへの接続
    

## 3. ゲームのプロジェクトダウンロード  
<https://github.com/igakilab/Onhold>からデータをcloneする。  
## 4. JDK(Java Development Kit)とSDKのダウンロード
<https://developer.android.com/studio/>からAndroid Studioをダウンロード。これを入れると、ついでにJDKとSDKがダウンロードされる。
## 5. ゲーム起動までの手順  
### 5-1. プロジェクト作成
Projects選択画面から右上にある「Open」を選択、「<<ダウンロードしてきたフォルダ>>→OnHold」へ進み、フォルダ選択で「VRrhythmGame」を選択する。
### 5-2. SDKとJDKのパスを通す
メニューバーから「Edit」「Preferences」を選択。External Toolsへ行き、下にあるAndroidの項目にあるSDKとJDKに、3.でダウンロードしたJDKとSDKを設定する。
SDKのpath例「C:\Users\<<ユーザー名>>\AppData\Local\Android\Sdk」  
JDKのpath例「C:\Program Files\Android\Android Stuido\jre」(jreになっているがJDKである)  
### 5-3. ゲームのビルドと実行
メニューバーから「File」「Build Settings」を開く。PlatformでAndroidを選択し、「Build And Run」を選択。ファイル名を適当に設定した後保存する。  
### 5-4. タイトルシーンからゲームスタート
Build And Runの場合、自動でOculus Go上にゲームが起動するので、「Game Start」をトリガーで選択すると、ゲームを開始することができる。  
## 6. 遊び方
音楽に合わせてブロックが流れてくるので、タイミングを合わせて振って斬る(当てるだけでも良い)。
音楽が終わるとスコアが表示され、ゲームが終了する。
