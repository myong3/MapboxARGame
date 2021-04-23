# MapboxARGame
* 工作分工
  黃湧文Owen Huang：遊戲製作、書面報告統整、導航功能、影片製作
  張竣傑：地圖設計、導航(路線規劃、時間\地點預估)
  鍾尚值：海報製作、遊戲製作、UI設計、PPT製作
  
* 摘要
  * 隨著 Pokemon go 爆紅之後，擴增實境（Augmented Reality, AR）技術漸漸成為炙手可熱的技術，學力至上這款APP是基於地理位置服務(Location-Based Service，LBS 又稱適地性服務、移動定位服務、位置服務)並結合AR所製成的。APP取得使用者位置後，告知使用者輔大校園各個建築的所在位置以及路線導覽，讓使用者能快速了解自己想要前往之目的地的方向。使用者介面(User Interface)上結合AR，使得導覽的內容以更直觀的方式顯示在行動裝置的螢幕上，如此一來能夠避免傳統的地圖導覽時需一一對照地圖才能使用之不便，並且將操作方式簡化方便使用者作操作。開發平台上使用Untiy，並且結合Mapbox-unity-sdk，使得支援Android和iOS系統。
  * 關鍵字：擴增實境、校園導覽、LBS
* 緒論
  * 前言
    * 科技的發展日新月異，地圖從早期傳統的紙本：傳統的導覽方式都是以圖片和文字搭配地圖的方式在呈現，所以每當使用者對於地圖的使用不是很熟悉時，那麼導覽的功能會大大降低，甚至會造成一定程度的誤解，進而迷路等違反地圖設計之初衷的結果。其實使用者最在使用時當下最迫切需要的就是要知道自己在哪裡以及距離目的地的方向，這些問題都是傳統地圖導覽沒辦法克服級解決的。到今天，因為智慧型裝置的普及化，現今已經有相當多實用的APP，如：Google Map、Apple Map，我們希望能夠除了APP能夠除了導覽以外，能夠增加一些互動性以及趣味性。
    * 擴增實境（Augmented Reality，簡稱 AR）是一種實時地計算攝影機影像的位置及角度並加上相應圖像的技術，這種技術的目標是在螢幕上把虛擬世界套在現實世界並進行互動，擴增實境於 1990 年提出。北卡大學 R. Azuma 於 1997 年提出擴增實境應包括三個方面的內容：虛擬物與現實結合、即時、三維(Azuma,1997)。由於擴增實境可以直接將資訊即時加在影像上，因此常被應用在導航導覽甚至娛樂上。而本研究專題是之擴增實境導覽系統，並以輔仁大學校園為例，提供各種智慧型行動裝置平台上的使用者可透過網路下載輔大校園之導覽，使得來到輔大的訪客都可以獲得最新最即時之導覽資訊。
  * 動機與目的
    * 對於初入輔大的大一新鮮人，亦或是初訪輔大的訪客們，每當進入偌大的輔仁校園，不知道何去何從時，只能透過輔大入口附近的校園導覽圖尋找，但卻不一定找的到目的地，最後只能透過詢問路人的方式到達目的地，於是我們決定作一款專為輔大設計的導覽APP。
    * 然而我們不只是要做普通的傳統型導覽APP，我們希望能夠結合擴增實境，利用一些有趣的小遊戲，除了導覽以外，結合校內各個建築的歷史，因此讓使用者在使用學力至上時，除了在導覽過程中不會趕到無聊，也可透過校園介紹更了解輔仁。
    * 經過多次討論與評估，我們決定讓遊戲盡量不要太過複雜以至於干擾到導覽及介紹的進行，由於智慧行動裝置的畫面大小有限，所以團隊希望讓使用者介面更為簡化，並透過教學方式讓使用者輕易上手。
    
* 開發工具介紹
   * Unity
   * Visual Studio
   * ARcore
   * ARKit
   * Mapbox studio
   * Git
   * Github
      * 版本控制方面，本專題使用的是Git，並使用GitHub服務。Git能清楚告知各個版本的不同之處，若現今版本有出錯，也能找回前一個版本，不會讓之前的辛苦白費。
      * 文字編輯器方面，本專題使用的是 Visual Studio，並使用C#撰寫
      * 遊戲開發方面，本專題使用的是 Unity，透過 Unity3D，使遊戲的所有功能與內容都能夠透過程式編寫有效的實現，並且使用mapbox-unity-sdk套件進行開發，而ARcore以及ARKit均包含在裡面。
      * 地圖設計方面，本專題使用的是Mapbox studio，利用客製化地圖功能，設計輔大的地圖。
  * 功能簡介
    * 開始登入畫面，進入後有分為AR以及Map選擇，如果只是想進行傳統的路線導航，可點擊右下角地圖的Bottom，但想要體驗AR導覽加上學員介紹的話，便可點擊左下角的目的地選擇清單，選擇清單裡包含了輔大的所有建築物和特殊景點，導覽過程中，路上會隨機冒出物件，透過時取物件提升經驗，當背包有足夠的物件時，可解鎖建築物，解鎖建築後，就可獲的建築物相關的歷史資訊。餐廳、圖書館和特殊景點都有相對應的功能，使用者可以到這些地方得到自己所缺乏的物件，解鎖完全部建築後，就可從學力至上畢業了！
  * 系統架構
    ![image](https://user-images.githubusercontent.com/38349902/47501552-666f5100-d898-11e8-83b0-24e27145cfa8.png)
     
* APP設計與實作  
  * Mapbox React Native AR vs Mapbox Unity AR vs SceneKit AR
  * Google Map API vs Mapbox Direction API
  * Map
    * DirectionFactory.cs
* APP成果與討論
    * 登入畫面
    * 新手教學
    * AR介面
      * 各大樓功能
      * 學校建築物介紹
      * AR路線導覽
    * Map介面
      * Map路線導覽
      * 返回使用者位置Bottom
    * 建築物選擇清單
      * 建築物選擇清單是主要是讓使用者可以直接透過
    * 背包功能
* 結論
  * 總結
    * 本專題最終製作出一款導覽APP為結合互動性與趣味性之AR導覽APP，以導覽為主要目的，透過AR或Map方式呈現，讓使用者拾取物件小遊戲得到成就感，除了到達目的地以外，更能夠了解相關的歷史資訊，讓大一新生或是訪客們更加地了解輔大校園。
  * 未來展望
    * 目前開發的學力至上這款APP缺乏
* 參考文獻 
  * [Embedded Virtual Views for Augmented Reality Navigation,2011](https://pdfs.semanticscholar.org/cbdb/3ee9a33331f8c4df78c355e90e640e998457.pdf)
  * [Augmented reality navigation systems,2006](https://www.researchgate.net/publication/220606626_Augmented_reality_navigation_systems)
  * [Comparative Assessment of Mobile Navigation Applications using 2D Maps and Augmented Reality Interfaces,2016](https://www.thinkmind.org/download.php?articleid=achi_2016_20_20_20279)
  http://www.tgis.org.tw/files/recruit/41_d7b0f246.pdf

  
  




=======
Using Unity/Mapbox/ARCore to develop Location Based AR Game 
>>>>>>> d2c3f6532cbf1f6b21e676f61623560072949e84
