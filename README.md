# Side-Project-Try-Swagger-RESTfulAPI



## 目的

幫老弟寫 API ，好練習串 API 接口與 ajax SSR 並補充網站知識，順便嘗試 RESTfulAPI 的 Lv 1 - 3，與 Swagger 套件。

## 概括網站系統設計

### 利用下列資料理解此圖流程

![alt](/網頁生命週期.png)

1. 理解下列名詞知道即可。


     * `域名系統` DNS / `網路位址(RealName)` IP / `域名(NickName)` DomainName / `通訊埠` Port [> 可參考](https://medium.com/@miahsuwork/%E7%AC%AC%E5%85%AD%E9%80%B1-%E7%B6%B2%E8%B7%AF%E5%9F%BA%E7%A4%8E-http-request-response-7d7e0cb88ed8)
     * `網路架構` (七層 OSI 模型)、(五層 TCP/IP 模型) [> 可參考](http://eportfolio.lib.ksu.edu.tw/~4970Q063/blog?node=000100005)
     * `網路協議` (Http/Https) (Socket) (HLS/RTMP) [> 可參考](https://twgame.wordpress.com/2015/02/03/tcpiphttpsocketudp/)
     * `封包` Data packet / `請求` Request / `回應` Response [> 可參考](https://yakimhsu.com/project/project_w4_Network_http.html)
     * `封包傳遞方式` get / post ( put / delete ) [> 可參考](https://www.google.com/search?sxsrf=ALeKk03llIX8j1ENlzd1w_55yKW6CQm-dA%3A1599410797452&ei=bRJVX9SbG863mAX6oaTwBA&q=get+post&oq=get+PO&gs_lcp=CgZwc3ktYWIQAxgAMgIIADICCAAyAggAMgIIADICCAAyAggAMgIIADICCAAyAggAMgIIADoFCAAQsQM6BAgAEEM6CAgAELEDEIMBUJF7WLGGAWC4jwFoAHAAeACAAUCIAfkBkgEBNZgBAKABAqABAaoBB2d3cy13aXrAAQE&sclient=psy-ab)

     * `網頁技術 - 網頁編寫方式` `靜態網頁` / `動態網頁`

     * `網頁生命週期(流程)` ( JS生命週期 ) [> 可參考](https://codertw.com/%E5%89%8D%E7%AB%AF%E9%96%8B%E7%99%BC/24350/)
     * `資料傳輸定義 - 應用程式介面(接口)` `API` ( Application Programming Interface )
     * `網頁技術 - 資料索取方式` `AJAX` ( Asynchronous JavaScript and XML )
     * `網頁技術 - 資料組成` `SPA` ( 單頁面應用程式 Single Page Application ) / `MPA` ( 多頁面應用程式 Multi-page Application ) / `PWA` ( 漸進式應用程式 Progressive Web Application) [> 可參考](https://blog.csdn.net/style_zyh/article/details/74216593)
     * `網頁技術 - 頁面產生方式` ( `靜態網站生成器` Static Site Generators / `客戶端渲染` Client Side Render / `伺服器端渲染` Server Side Render )[> 可參考](https://www.jianshu.com/p/f8b4f3776d9f)
     * `後端應用` ( Framework `程式框架` / Framework Language `程式語言` / `直、編譯` / `框架、語言生命週期(流程)` [> 可參考 wiki 有寫很詳細這三個名詞差異](https://adon988.logdown.com/posts/7597721-asp-dot-net-life-cycle) )
     * `後端應用` ( Database `資料庫` / Database Management System `資料庫管理系統` / SQL `資料庫管理系統語言` ) [> 可參考 wiki 有寫很詳細這三個名詞差異](#)

     * `集中式系統` / `分散式系統` [> 可參考](https://rickhw.github.io/2018/06/18/Architecture/Gossip-in-Distributed-Systems/#%E4%B8%89%E3%80%81%E7%95%B6%E4%BB%A3%E5%B7%A5%E7%A8%8B%E6%96%B9%E6%B3%95%E8%88%87%E5%AF%A6%E8%B8%90)

     <P> </P>
     <details>
       <summary>延伸文章</summary>
       <P> </P>

     * [三種渲染畫面方式](https://juejin.im/post/6855917901090652174)

     </details>

2. 簡單理解下列題目。
     1. `動態` 與 `靜態網頁` 差別 ?
        <details>
          <summary>參考答案</summary>
          <p> 靜態網頁副檔案名稱為 .html，動態網頁則依據不同的框架、不同的程式語言而有多種副檔名如 .php .asp .jsp，唯一不變的是，通常除了快取用途而載入客戶端(本地/本機)的檔案，不管是靜或動態檔案都會放置於伺服器端(後端/雲端)再藉由請求提供響應的資料至客戶端。 </p>
        </details>
     2. `程式框架` 、 `編譯/直譯` 、 `程式生命週期` 三者之間的關係 ?
        <details>
         <summary>參考答案</summary>
         <p> 不同 "程式框架" 擁有不同的 "程式生命週期" ，但根據語言特性分為編譯與直譯，但不管是編譯或是直譯都是一行一行的依邏輯讀取，讀完再依邏輯換頁讀取，只要不是 .html 為副檔名都需要經過編譯成 html 檔案，瀏覽器才讀得懂，或是響應局部資料 text / json / js / css 至前端由 js 處理。 </p>
        </details>
     3. 以郵差寄信形容較簡單的 `集中式系統` 與 `OSI 七層` 或 `ICP/IP 五層` 之間的關係 ?  [> 可參考](http://eportfolio.lib.ksu.edu.tw/~4970Q063/blog?node=000100005)
        <details>
         <summary>參考答案</summary>
         <p>集中式系統通常指的就是將伺服器程式、網頁軟體程式、資料庫程式放在同一台主機；</p><p>而此處以一台集中式系統與一台客戶端電腦來舉例 郵差 OSI 七層，</p><p>首先封包信件會由客戶端電腦透過 URL(DomainName) 先到各國的 DNS 做尋址以類似縣市鄉鎮區方式，最終找到集中式系統的所在位址，</p><p>此時有些公司或自家會再利用一台 DNS 主機 做分流管控/防火牆或是藉由路由器分流進入內網或直接進入集中式系統，這都屬於 OSI 實體層範圍，</p><p>通過網路終線路，找到集中式系統的網路卡由此處理 OSI 資料連階層，</p><p>接著進入抽象的硬碟內 OSI 網路層、傳送層、會談層以上四層，通常伺服器軟體會幫我們處理，我們只需要設定即可，</p><p>接著到了 OSI 表現層，這裡就是我們通常接觸到將封包 依照 URL </p><p><a href="#">http:123.123.123(主機位置)/xxx(訪問網站檔案位置)/Sample(method名稱)?name=allen(get方法傳遞的參數)</a></p><p> 上的指引轉交由 網頁軟體程式的 API 接口 ( xxx檔案內的 Sample method(string name (參數)) )，</p><p>在經過 網頁軟體程式 的控制流程，邏輯處理、控制資料庫等方式渲染出回傳的封包，依照同樣路線返回客戶端電腦，到此則成功完成一次 請求-響應。</p>
        </details>
     4. `AJAX` 與 `CSR 前端渲染`、`SPA 單頁應用程式` 之間的關係 ? [> 可參考](https://ithelp.ithome.com.tw/articles/10187675)
        <details>
         <summary>參考答案</summary>
         <p>傳統的網頁一次請求與響應會非常耗時耗能，而 AJAX ( 非同步 js 與 xml 技術 ) 則是在網頁背景 請求響應，向集中式系統 ( 伺服器 ) 取回必須的資料 ( XML、JSON、HTML、CSS、JS、TEXT... )，並在背景利用 JS 處理取回來的資料，對頁面進行渲染。<p>但這樣也是有壞處的，網頁瀏覽器並不會自動幫你記住某些記憶體狀態，這些內容可能在下一次的請求與響應就永久消失，(所以出現了現代前端框架幫忙解決這個問題)</p><p>而前端渲染 SSR 指的則是，除了第一次瀏覽時需要整頁 HTML，在之後不再藉由後端傳輸整頁 HTML 而是只取局部資料，並利用 JS 將這些資料做頁面的改動即是前端渲染 SSR。</p><p>而 SPA 則是更極端，是由一頁的 HTML 與大量的 JS 所組成，所有資料都藉由 XML、JSON、TEXT 傳送至前端再由前端框架針對此單頁 HTML 做再渲染，但這些方法都具有好處與壞處，需根據不同的應用選擇架構。</p>
        </details>
     5. 封包傳遞方法 `POST` 與 `GET` 之間的差異 ? [> 可參考](https://blog.toright.com/posts/1203/%E6%B7%BA%E8%AB%87-http-method%EF%BC%9A%E8%A1%A8%E5%96%AE%E4%B8%AD%E7%9A%84-get-%E8%88%87-post-%E6%9C%89%E4%BB%80%E9%BA%BC%E5%B7%AE%E5%88%A5%EF%BC%9F.html)
        <details>
         <summary>參考答案</summary>
         <p>GET 像明信片對外、顯示明碼於 URL 上、較小不能塞過多的資訊，POST 像信封、將明碼藏於封包內、較大能塞較多資訊，但後者相較於前者只是較隱匿，兩者皆不能阻止想查閱信件內容的人讀取信件 ( 但前提是他要攔截的到郵差 )。兩者大小限制 <a href="https://www.itread01.com/content/1546869788.html">> 可參考</a></p>
        </details>

     6. `生命週期(流程)`、`控制邏輯`、`元件庫/元件/函式庫/函式/模組`、`API` 之間的關係 ? [> 可參考](https://blog.csdn.net/style_zyh/article/details/74216593)
        <details>
         <summary>參考答案</summary>
         <p>其實程式在 CRUD 的範疇時非常簡單，一個問題配合答案，只要能越清楚的形容得出來，就能越簡單的寫成程式；</P><P>原理是 : 編譯或是直譯語言，在框架內都是由檔案的第一行執行到最後一行的，在視情況 ( 控制流程 ) 換檔案執行，而這就是所謂的 "程式的生命週期" ，從 request 資料包 進入程式到程式回傳 response 稱為 "網頁程式的一次生命週期"，而在這次生命週期間會經過許多 控制邏輯、控制流程、操控資料庫 等各種可能性，而這些都仰賴別人寫好的 元件庫/函式庫 。</p><p>而 `元件庫/元件/函式庫/函式/模組`，其實就只是別人或一組團隊所開發的程式包。</p><p>最後就要來談 API 到底是什麼了，API 其實就是定義剛剛所述一堆介面之間傳遞資料的格式，讓不同介面之間能知道互相的接口才知道要傳遞什麼樣的資料。( 例如 : 三孔插座只能插三插或兩插的，肯定不能插四插的。 110v 插座 220v 的電器肯定不能用。 )</p>
        </details>
     7. 上述 `資料組成` 、 `頁面產生方式` 之間的差異 ? 與 `資料索取方式` 之間的關係 ?
        <details>
         <summary>參考答案</summary>
         <p>網頁資料組成可分為 `單頁`、`多頁`、`漸進`，單頁是現代網頁常見的設計方式，藉由一頁 HTML 在客戶端利用 API 取來的資料重複渲染此頁面，</p><p>相較於傳統 多頁式 每一頁都需要經過 客戶端要求 後端響應 提供要求頁面來說，可以省去資料傳輸量，相對的也不會受限於網路速度，可以像單機程式般應用，例如 GMAIL，</p><p>再來是 漸進式 是由 Google 近年來提出的想法，藉由在客戶端直接載入部分的 單機程式 ( js ) ，讓網路應用程式使用起來更像單機程式，例如開機畫面，或是單機應用等等...</p><p>再來提到的是 HTML 頁面產生方式分為 `靜態頁面產生器`、`客戶端渲染`、`伺服器端渲染`，靜態頁面產生器 與 伺服器端渲染 通常都位於 架站所在的主機，</p><p>差別在於 靜態頁面產生器 還是需要一頁一頁的手刻，藉由 pug 或 markdown 等模板語言增加編寫速度，再利用樣式模板套版產生靜態網頁，省去一頁一頁複製重複利用程式碼時間；</p><p>而 伺服器渲染 則需要利用 程式語言 編寫 控制、邏輯、流程 利用程式自動化渲染頁面 提供給 要求方，</p><p>最後則是 客戶端渲染，如上述所講通常為 單頁式 利用 js 框架，將提取來的資料對頁面做渲染；而資 料索取方式 則分為直接 要求響應 ( 網頁會重新 reload 左上角會跑圈圈 ) 與 藉由某些事件觸發 在背景利用 AJAX 要求響應。</p>
        </details>
     8. `資料庫`、`資料庫管理系統`、`資料庫管理系統語言` 之間的關係 ? [> 可參考](https://www.google.com/search?rlz=1C1CHBF_zh-TWTW905TW905&ei=ZNpYX_CcMovU0gSFiY_4Ag&q=%E8%B3%87%E6%96%99%E5%BA%AB%60%E3%80%81%60%E8%B3%87%E6%96%99%E5%BA%AB%E7%AE%A1%E7%90%86%E7%B3%BB%E7%B5%B1%60%E3%80%81%60%E8%B3%87%E6%96%99%E5%BA%AB%E7%AE%A1%E7%90%86%E7%B3%BB%E7%B5%B1%E8%AA%9E%E8%A8%80&oq=%E8%B3%87%E6%96%99%E5%BA%AB%60%E3%80%81%60%E8%B3%87%E6%96%99%E5%BA%AB%E7%AE%A1%E7%90%86%E7%B3%BB%E7%B5%B1%60%E3%80%81%60%E8%B3%87%E6%96%99%E5%BA%AB%E7%AE%A1%E7%90%86%E7%B3%BB%E7%B5%B1%E8%AA%9E%E8%A8%80&gs_lcp=CgZwc3ktYWIQAzIFCAAQzQIyBQgAEM0CUMSsG1jErBtgt68baABwAHgAgAFtiAFtkgEDMC4xmAEAoAECoAEBqgEHZ3dzLXdpesABAQ&sclient=psy-ab&ved=0ahUKEwjw3rPTmNzrAhULqpQKHYXEAy8Q4dUDCA0&uact=5)
        <details>
         <summary>參考答案</summary>
         <p>資料庫是一種 "儲存" 資料的程式，又分為 關聯式 與 KeyValue式，基本上 資料庫、資料表 開的好，程式就越容易寫；</p><p>而 資料庫管理系統 顧名思義就是管理 資料庫 的程式，一般來說 資料庫程式 只負責 接收指令進行 CRUD ，而 資料庫管理系統 提供了 GUI 讓操作者方便對 資料庫程式 執行指令，進行 CRUD；</p><p>而 SQL 則是針對 資料庫 做 CRUD 的指令。</p>
        </details>
     9. `後端應用`、`資料庫應用`、`API 接口` 之間的關係 ? [> 可參考](https://zh.wikipedia.org/wiki/ADO.NET)
        <details>
         <summary>參考答案</summary>
         <p>後端是由 框架 ( 類似一堆資料的固定應用方式，規範 程式的生命週期 與 整合函式庫 與 串接資料庫應用 )，而 API 接口 則是在不同的介面定義傳輸的資料格式，</p><p>舉例來說 後端框架 與 資料庫程式 中間就會藉由 資料庫實體物件 ( 進行資料庫程式的帳號密碼登入 ) 或是 Table Row Data 等物件 ( 裝載資料庫查出來的資料乘載的容器 ) ，進行 API 串接，讓 後端程式 有辦法利用到 資料庫 內的資料。</p>
        </details>
     10. `集中式系統`、`分散式系統` 之間的差異 ? [> 可參考](https://www.google.com/search?q=%E9%9B%86%E4%B8%AD%E5%BC%8F%E7%B3%BB%E7%B5%B1%60%E3%80%81%60%E5%88%86%E6%95%A3%E5%BC%8F%E7%B3%BB%E7%B5%B1&rlz=1C1CHBF_zh-TWTW905TW905&oq=%E9%9B%86%E4%B8%AD%E5%BC%8F%E7%B3%BB%E7%B5%B1%60%E3%80%81%60%E5%88%86%E6%95%A3%E5%BC%8F%E7%B3%BB%E7%B5%B1&aqs=chrome..69i57.338j0j4&sourceid=chrome&ie=UTF-8)
         <details>
          <summary>參考答案</summary>
          <p>將上述提到的不同系統，放置於不同的電腦，藉由分散系統達到更大的負荷乘載，流量分流管控等...並利用網路線路連結不同系統的應用，或是 集中式系統 將一般的電腦升級為 伺服器級別電腦 等等範疇，但會在 易維護 與 效能 之間拉鋸，也是架構師必須解決的問題。</p>
         </details>


     <p> </p>
     <details>
       <summary>延伸文章</summary>
       <P> </P>
       * 待補
     </details>

3. 依照前三學習到的基礎常識，並依照下列步驟，串接API並推版至 DBUG 專案。
   <p> 1. 首先將此專案 clone 至本地 ( 目的是部屬 API框架 後端程式，用來利用 debug 模式完成虛擬架站，產生 json 資料供前端靜態檔案做 AJAX 串接 )。
   <p> 2. 新建一個資料夾用 vscode 打開資料夾 ctrl + p ， > git: clone 。
   <p> 3. 克隆好後打開資料夾會看到， DPERFUME-API 資料夾 是用 .net core 框架 寫的 api 專案。
   <p> 4. 接著這邊先暫時擱置備用，先處理 DBUG 版控。
   <p> 5. 首先登入 github DBUG 點擊 NEW 並新增此次 API 練習用 Public 專案，檔名建議需能辨識出此次練習技術 e.g. Side-Project-AJAX-API-Cascade。
   
   ![alt](/img/1.png)
   
   <p> 6. 照著第二步驟將此 專案 挑個 資料夾版控，並建立 README.md 檔案，紀錄所作步驟與遇到的問題與解法。
   <p> 7. 接著將 API專案 DPERFUME-API 資料夾 複製剪貼至此。
   <p> 8. 並將此次要串接的靜態檔案 ( html / css / js ) 搬至此新建資料夾 放置靜態檔案，大致上的畫面如下。
   
   ![alt](/img/2.png)
   
   <p> 9. 接著打開 DPERFUME-API 資料夾 用 visual studio 打開 附檔名為 .sln 的專案檔， visual studio 與 vscode 差別就是一個是 IDE ( 整合開發環境 Integrated Development Environment ) 一個是比較偏向 文字編輯器 <a href="https://www.google.com/search?q=IDE+%E5%B7%AE%E5%88%A5+%E6%96%87%E5%AD%97%E7%B7%A8%E8%BC%AF%E5%99%A8&rlz=1C1CHBF_zh-TWTW905TW905&oq=IDE+%E5%B7%AE%E5%88%A5+%E6%96%87%E5%AD%97%E7%B7%A8%E8%BC%AF%E5%99%A8&aqs=chrome..69i57.6434j0j1&sourceid=chrome&ie=UTF-8">> 可參考</a>。<details><summary>整合開發環境 vs 文字編輯器</summary><p>程式語言可以分成兩種型式 1.直譯式語言 2.編譯式語言</p>

<p>直譯式語言，
當你的代碼寫完後，
直接餵給執行環境就能運行，
常見的例子是 Javascript，
寫完後不需要做特別的處理，
直接餵給執行環境(以Chrome 瀏覽器來說為V8 engine)，
就能夠執行了</p>

<p>編譯式語言，
代碼寫完後要先透過 編譯器(compiler) 進行編譯，
編譯後的檔案再拿去給執行環境執行，
例子是Java，
JAVA 的 source code 副檔名為 .java，
拿去 complie 後會變成副檔名為 .class 的檔案，
再拿 .class 給JAVA的 runtime 也就是 JVM 進行執行</p>

<p>惡補完，
我們來討論IDE，
如你所見在撰寫編譯式語言時，
步驟相當繁瑣，
不依靠任何整合工具的情況下，
我要寫隻程式並執行要有下列步驟</p>
<p>1.開啟 editor 敲code</p>
<p>2.敲完了打開 cmd 呼叫工具來編譯，javac xxx.java</p>
<p>3.編譯後要執行 .class，java xxx</p>

<p>Integrated Development Environment，
IDE 的全名，
整合開發環境，
是為了提高我們的產值打造的工具，
它會整合各種工具，
例如讓上述的步驟透過一個按鈕就全部執行完成，
就不用每一次寫扣都要手動執行那個三個步驟了</p></details>
   
   <p> 10. 試著重建方案，看是否有報錯。
   
   ![alt](/img/3.png)
   
   <p> 11. 接著按下 debug 模式，利用 visual studio debug 虛擬 iis 來進行虛擬架站。
   <p> 12. 此模式會產生一個虛擬 iis 伺服器並將此 api 網站架設於此，必須藉由 debug 模式才會啟動並配置一個虛擬站台 <a href="#"> http://localhostXXXX </a>，當 debug 模式 結束後會自動釋放資源，這時透過 url 就無法調用到此網頁軟體程式 ，後續想了解如何部屬至真正的 iis 再問我。
   
   ![alt](/img/4.png)
   
   <p> 13. 接著程式會自動開啟預設的 Swagger API 介紹畫面，此頁面只是方便測試 api 有需要再來用，通常業界是用 PostMan 軟體。
   <p> 14. 接著就是要了解如何串接資料，為避免麻煩先將 api ALL 會產生的 JSON 資料貼於下方便解釋。後續會解釋如何向 api 框架要求 json 的 responce。
   <p> 15. <a href="https://github.com/johch3n611u/Side-Project-Try-Swagger-RESTfulAPI/blob/master/All.json">https://github.com/johch3n611u/Side-Project-Try-Swagger-RESTfulAPI/blob/master/All.json</a>
   <p> 16. 將上列 json 的內容複製於以下 方便解釋此 json 資料結構
   <p> 17. <a href="https://jsoneditoronline.org/#left=local.hedozu&right=local.denobi">https://jsoneditoronline.org/#left=local.hedozu&right=local.denobi</a>
   <p> 18. 複製於左按下 Copy 右邊則是此次 JSON 的整頁資料結構。
   <p> 19. JSON 是由 KEY VALUE 所組成的格式，有一些制式化的規定如以下。
       * 最外層必須由 {} 花括弧包住代表著這是 JSON 物件
       * KEY 必須用 雙引號 包覆
       * Value 可以是 "字串" 、 123 數字 、 null 、 {物件} 、 [陣列]，並用 , 逗點相隔
   
   ![alt](/img/5.png)
   
   <p> 20. 展開右側可以看到範例此次所有型別都有包含，如果格式有錯此網頁會自動提示，通常編輯器也會，可以試看看。
   <p> 21. 接著介紹範例 JSON 設計的結構方便串接。
       * 首先 Layout 內涵蓋 header 與 footer 與 shopcar 的資料
       * 然後 banner 則是看版圖的資料
       * columnProducts 則是橫排商品資料
       * steps 則是步驟所需資料
       * rowProducts 則是直排商品資料
       * finalProduct 則是最底的商品資料
       * 目前資料筆數都依照畫面調出
       * 接著在實作 AJAX 前端資料索取方式前，我們先在利用
       

## 前端工具( 物件, 模組 )

* XMLHttpRequest 原生 API
* jQuery.ajax() 第三方庫
* fetch 原生 API

<https://developer.mozilla.org/zh-TW/docs/Web/API/Fetch_API/Using_Fetch>

<https://wcc723.github.io/javascript/2017/12/28/javascript-fetch/>

<https://developer.mozilla.org/zh-TW/docs/Web/API>

<https://www.itread01.com/content/1564589404.html>

1. 看完了文章後
2. 試著對著URL 調用 API 則可以得到 JSON 的 Response
![alt](/img/6.png)

> 以下為API框架後端程式 實作，不用特別看

---

![alt](/TryIt.gif)

## [RESTfulAPI 簡介 by https://openhome.cc](https://openhome.cc/Gossip/Spring/HATEOAS.html)

* Level 0 -  使用 HTTP 做為資料傳輸的媒介。

* Level 1 - 不要提供一個包山包海的 API，而是要區分資源，每個資源都該有對應的 API。

使用多個 URI 與一個 HTTP 方法，URI 代表了資源，像是 /show_message、/create_message、/update_message、/delete_message 都是資源，HTTP 方法只是用來發起請求，至於請求的細節由請求本體來提供，例如，在請求 /show_message 這項資源時，若包含 all 請求參數，表示顯示全部的訊息，若是 "id=1" 這類請求參數，表示顯示指定的訊息。

* Level 2 - 透過 HTTP Method 區分新增(Create)、查詢(Read)、修改(Update)跟刪除(Delete)。

使用多個 URI、多個 HTTP 方法，並善用 HTTP 回應狀態碼，URI 用來代表資源，像是 /messages、/messages/1，HTTP 方法用來表示想進行的操作，例如 GET /messages 表示取得全部訊息，GET /messages/1 表示取得指定訊息，POST /messages 表示新增訊息、DELETE /messages/1 表示刪除指定訊息等，〈簡介 RestTemplate〉的簡單應用程式就是此類。

* Level 3 - 對同資源可以用鏈結表達的方式，向下延伸查詢或修改。

更進一步地，支援 HATEOAS（Hypermedia As The Engine Of Application State）的概念，就類似 HTML 頁面鏈結，你可以從這個頁面得知可通往哪些頁面，在 REST 的 Level 3 模型中，客戶端可以從某個資源，知道還有哪些其他相關的資源，以及如何對它進行操作，〈@RepositoryRestResource〉的範例專案，就是這一類。

## API 實作步驟

1. 跟著步驟做 DTO 與 API
2. 網址為 <https://localhost:44317/swagger/index.html>
3. [研究動態泛型 反應式程式設計](https://mileslin.github.io/2016/12/%E5%8B%95%E6%85%8B%E6%8C%87%E5%AE%9A%E6%B3%9B%E5%9E%8B%E5%9E%8B%E5%88%A5/)
4. [最後動態泛型的反傳值沒研究成功，有時間再研究...](https://docs.microsoft.com/zh-tw/dotnet/csharp/programming-guide/generics/generic-methods)

## 參考

<https://blog.johnwu.cc/article/ironman-day13-asp-net-core-web-api-document-generator-swagger.html>

<https://openhome.cc/Gossip/Spring/HATEOAS.html>

<https://blog.johnwu.cc/article/ironman-day12-asp-net-core-restful-api.html>

<https://xd.adobe.com/view/dc5ebe5c-3e56-4981-a010-158b5ded0e72-890d/grid>

<https://dotblogs.com.tw/AceLee/2019/11/05/125029>

<https://li-jin-xing-vulcan.gitbook.io/csharp/genericdynobject>

<https://mileslin.github.io/2016/12/%E5%8B%95%E6%85%8B%E6%8C%87%E5%AE%9A%E6%B3%9B%E5%9E%8B%E5%9E%8B%E5%88%A5/>
