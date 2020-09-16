# 實作步驟 - 前端靜態AJAX 與 API後端 網站

## 大綱

1. [環境架設 1-12](#A)
2. [原理解析 13-31](#B)
3. [Demo實作講解 32-.](#C)

<br>

<br>

<br>

<br>

<br>


## 依照前三學習到的基礎常識，並依照下列步驟，串接API並推版至 DBUG 專案

   <p id="A"> 1. 首先將此專案 clone 至本地 ( 目的是部屬 API框架 後端程式，用來利用 debug 模式完成虛擬架站，產生 json 資料供前端靜態檔案做 AJAX 串接 )。</p>
   <p> 2. 新建一個資料夾用 vscode 打開資料夾 ctrl + p ， > git: clone 。</p>
   <p> 3. 克隆好後打開資料夾會看到， DPERFUME-API 資料夾 是用 .net core 框架 寫的 api 專案。</p>
   <p> 4. 接著這邊先暫時擱置備用，先處理 DBUG 版控。</p>
   <p> 5. 首先登入 github DBUG 點擊 NEW 並新增此次 API 練習用 Public 專案，檔名建議需能辨識出此次練習技術 e.g. Side-Project-AJAX-API-Cascade。</p>

   ![alt](/img/1.png)

   <p> 6. 照著第二步驟將此 專案 挑個 資料夾版控，並建立 README.md 檔案，紀錄所作步驟與遇到的問題與解法。</p>
   <p> 7. 接著將 API專案 DPERFUME-API 資料夾 複製剪貼至此。</p>
   <p> 8. 並將此次要串接的靜態檔案 ( html / css / js ) 搬至此新建資料夾 放置靜態檔案，大致上的畫面如下。</p>

   ![alt](/img/2.png)

   <p> 9. 接著打開 DPERFUME-API 資料夾 用 visual studio 打開 附檔名為 .sln 的專案檔， visual studio 與 vscode 差別就是一個是 IDE ( 整合開發環境 Integrated Development Environment ) 一個是比較偏向 文字編輯器 <a href="https://www.google.com/search?q=IDE+%E5%B7%AE%E5%88%A5+%E6%96%87%E5%AD%97%E7%B7%A8%E8%BC%AF%E5%99%A8&rlz=1C1CHBF_zh-TWTW905TW905&oq=IDE+%E5%B7%AE%E5%88%A5+%E6%96%87%E5%AD%97%E7%B7%A8%E8%BC%AF%E5%99%A8&aqs=chrome..69i57.6434j0j1&sourceid=chrome&ie=UTF-8">> 可參考</a>。<hr><details><summary>整合開發環境 vs 文字編輯器</summary><p></p><p>程式語言可以分成兩種型式 1. 直譯式語言 2. 編譯式語言</p><p>直譯式語言，當你的代碼寫完後，直接餵給執行環境就能運行，常見的例子是 Javascript，寫完後不需要做特別的處理，直接餵給執行環境 ( 以 Chrome 瀏覽器來說為 V8 engine )，就能夠執行了</p><p>編譯式語言，代碼寫完後要先透過 編譯器 ( compiler ) 進行編譯，編譯後的檔案再拿去給執行環境執行，例子是 Java，JAVA 的 source code 副檔名為 .java，拿去 complie 後會變成副檔名為 .class 的檔案，再拿 .class 給 JAVA 的 runtime 也就是 JVM 進行執行</p><p>接著 IDE，如你所見在撰寫編譯式語言時，步驟相當繁瑣，不依靠任何整合工具的情況下，我要寫隻程式並執行要有下列步驟</p><p>1. 開啟 editor 敲 code</p><p>2. 敲完了打開 cmd 呼叫工具來編譯，javac xxx.java</p><p>3. 編譯後要執行 .class，java xxx</p><hr><p>Integrated Development Environment 整合開發環境 IDE</p><p>是為了提高我們的產值打造的工具，它會整合各種工具，例如讓上述的步驟透過一個按鈕就全部執行完成，就不用每一次寫扣都要手動執行那個三個步驟了。</p></details>
   <hr>
   <p> 10. 試著重建方案，看是否有報錯，如缺少套件/函式庫則右鍵更新下載。</p>

   ![alt](/img/3.png)

   <p> 11. 接著按下 debug 模式，利用 visual studio debug 虛擬 iis 來進行虛擬架站。</p>
   <p> 12. 此模式會產生一個虛擬 iis 伺服器並將此 api 網站架設於此，必須藉由 debug 模式才會啟動並配置一個虛擬站台 <a href="#"> http://localhostXXXX </a>，當 debug 模式 結束後會自動釋放資源，這時透過 url 就無法調用到此網頁軟體程式 ，後續想了解如何部屬至真正的 iis 再問我。</p>

   ![alt](/img/4.png)

   <p id="B"> 13. 接著程式會開啟我設定預設的 Swagger API 介紹畫面，此頁面只是方便測試 api，通常業界是用 PostMan 軟體。</p>
   <p> 14. 在了解如何串接資料之前要先了解，如何透過 url 向 api 框架要求 json 的 responce。</p>
   <p> 15. 首先看向 url 我們可以知道，目前 api 框架是架設於 http://localhost:XXXXX/ 之上，而在不看後端程式碼的況狀下我們可以透過 Swagger 頁面了解 API 路徑該如何調用 </p>
   <p> 16. 首先看到第三個 /api/Default/{All} 展開，可以看到 Try it out 點擊後 在描述 All 參數輸入任意值並 Execute，我們就可以看到 Request URL 與 Response body </p>

   ![alt](/img/7.png)

   <p> 17. 接著將 https://localhost:44317/api/Default/S 開新分頁貼上，http://localhost:XXXXX (主機) / api (檔案) / Default (方法) / S (參數) 這就是 .NET CORE API 框架 解析 URL 的邏輯，不一定每個框架都是此邏輯，實際上可以自定義。</p>
   <p> 18. 接著我們可以下斷點 看這段 https://localhost:44317/api/Default/S 實際上在軟體程式內做了什麼 </p>

   ![alt](/img/import.gif)

   <p> 19. 首先在一開始可以看到我們這時伺服器已經起始初始化過了，所以雖然在初始化的檔案內有設置斷點，但調用 method 的時候並不會進入該檔案。</p>
   <p> 20. 而是直接進入控制台檔案內找 Get 方法 參數有 All 的接口，並反傳一個已經塞好資料的 homepage json 檔案。</p>
   <p> 21. 接著我們嘗試看看要怎麼樣才會調用到初始化網站的檔案，答案是重啟整個 網站，所以我們可以知道 初始化只會在啟動網站時執行一次 </p>
   <p> 22. 可以看到跟著左邊的初始化，右邊的畫面也跟著卡著斷點 或是成功渲染畫面。</p>
   <p> 22. 接著我們嘗試調用第一種多參數的查詢方法，我們可以看到此時進入了另外一個帶有三個參數的 methon 前兩個有而最後一個並沒有參數，並跟著邏輯取回相對應的 json 資料。</p>
   <p> 23. 此時我們回到 Swagger 頁面 可以看到 Request URL = https://localhost:44317/api/Default?PageName=Homepage&PartName=Layout </p>
   <p> 24. 這個上述 https://localhost:44317/api/Default/S 有什麼不同呢 ? 因為這是我設計過的接口，當無參數名稱時自動將第三格判定為 All 的參數。 主機位置/程式/all參數</p>
   <p> 25. 整個後端的簡單調用邏輯大約是這樣，有不懂的問盡量問才會懂</p>

   ![alt](/img/6.png)

   <p> 26. 接著將上列調用到的 json 的內容複製於以下 方便解釋此 json 資料結構</p>
   <p> 27. <a href="https://jsoneditoronline.org">https://jsoneditoronline.org</a></p>
   <p> 28. 複製於左按下 Copy 右邊則是此次 JSON 的整頁資料結構。</p>
   <p> 29. JSON 是由 KEY VALUE 所組成的資料格式，有一些制式化的規定如以下。</p>

       * 最外層必須由 {} 花括弧包住代表著這是 JSON 物件
       * KEY 必須用 雙引號 包覆
       * Value 可以是 "字串" 、 123 數字 、 null 、 {物件} 、 [陣列]，並用 , 逗點相隔

   ![alt](/img/5.png)

   <p> 30. 展開右側可以看到範例此次所有型別都有包含，如果格式有錯此網頁會自動提示，通常編輯器也會，可以試看看。</p>
   <p> 31. 接著介紹範例 JSON 設計的結構方便串接。</p>

       * 首先 Layout 內涵蓋 header 與 footer 與 shopcar 的資料
       * 然後 banner 則是看版圖的資料
       * columnProducts 則是橫排商品資料
       * steps 則是步驟所需資料
       * rowProducts 則是直排商品資料
       * finalProduct 則是最底的商品資料
       * 目前資料筆數都依照畫面調出
       * 接著在實作 AJAX 前端資料索取方式前，我們先在利用

   <p id="C"> 32. 接著就要進入最精彩的環節了，在前端靜態頁面利用 js 調用 AJAX 技術，在後端吃到反傳值。</p>

<hr>
<details>
<summary>參考資料 - 可以優先閱讀再進行下面步驟</summary>
<p></p>
<p>前端工具( 物件, 模組 )</p>

* XMLHttpRequest 原生 API
* jQuery.ajax() 第三方庫
* fetch 原生 API

<https://developer.mozilla.org/zh-TW/docs/Web/API/Fetch_API/Using_Fetch>

<https://wcc723.github.io/javascript/2017/12/28/javascript-fetch/>

<https://developer.mozilla.org/zh-TW/docs/Web/API>

<https://www.itread01.com/content/1564589404.html>

</details>
<hr>

  <p> 33. 看完了文章後，我這邊進行小小的 demo 示範如何在前端透過 AJAX 取得資料並透過 控制流程 渲染畫面，而你就要舉一反三了，記得有問題就問。</p>
  <p> 34. 我示範簡單利用 JQ AJAX 的，建議你三種方法都嘗試看看。</p>
  <p> 35. 記住此時你的 API 專案必須在 debug 虛擬 iis 上，或是真的部屬在伺服器上，不然就無法藉由 url 調用到資料。</p>
  <p> 36. JQ AJAX 方法可以設定當 API 回傳 400 或 500 狀態碼時會做什麼。可以想一下利用此方法可以做些什麼事 e.g. 跳轉錯誤頁面而不是死機。</p>
  <p> 37. 正常狀況下，串接 API 很容易遇到這種錯誤 Access-Control-Allow-Origin ，這是因為後端為防範 inject 所以不允許跨站要求資料，可以看到因為我們靜態頁面是用 127.0.0.1:8080 這個主機起的，這個是 liveServer 的小型伺服器，相對 localhost:XXXXX 其實就是兩個網域了。</p>

  ![alt](/img/8.png)

  <p> 38. 解決方法有兩種 1. 將靜態頁面般至同後端網域的主機上 2. 開啟後端網域的限制，3. 或是白名單。 我們這裡先使用第二種 </p>
  <p> 39. 由我改後端即可 <a href="https://blog.johnwu.cc/article/ironman-day26-asp-net-core-cross-origin-requests.html">https://blog.johnwu.cc/article/ironman-day26-asp-net-core-cross-origin-requests.html</a></p>
  <p> 40. 當然你看到這裡時候端版控應該也是改完的版本了。我們接續</p>
  <p> 41. <a href="https://www.w3school.com.cn/jquery/ajax_ajax.asp">https://www.w3school.com.cn/jquery/ajax_ajax.asp</a>

  ![alt](/img/jqajax.gif)

  <p> 42. 這邊可以看到我們已經從 http://localhostXXXX 成功取回 json 至 127.0.0.1</p>
  <p> 43. <a href="https://github.com/johch3n611u/Side-Project-Try-Swagger-RESTfulAPI/blob/master/Static/JQ.AJAX.html">https://github.com/johch3n611u/Side-Project-Try-Swagger-RESTfulAPI/blob/master/Static/JQ.AJAX.html</a></p>
  <p> 44. 接著可以先看懂以上程式碼，應該就能真的嘗試操作了。</p>

  ![alt](/img/jqajax2.gif)

  <p> 45. 更進階的例如說 按下分頁按鈕才取該頁資料，或是 AJAX POST 方法處理帳號密碼驗證。可以先等這頁串起來再接續。</p>
  <p> 46. demo ㄑ全部包含進階的部分，補在 AJAX.Sample.html 與 JQ.AJAXDemo.html 內，有問題直接問我才會比較快。</p>