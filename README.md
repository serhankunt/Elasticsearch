- Apache Lucene alt yapısı kullanıyor.
- Elasticsearch, giriş paragrafında da bahsedildiği gibi büyük ölçekli veritabanlarında hızlı arama, analiz, veri depolama ve geri alma işlemleri için kullanılan, Apache Lucene kütüphanesine dayandırılmış, oldukça güçlü bir tam metin arama(full-text search) motorudur.
Elasticsearch, NoSQL tabanlı davranış sergilemekte ve verileri JSON formatında depolamaktadır. Bu veriler üzerinde yazımız boyunca detaylandıracağımız yapılandırılmış ve yapılandırılmamış sorgulama, gerçek zamanlı analiz, filtreleme vs. gibi kazanımları uygulamaktadır.
Elasticsearch, büyük miktardaki verileri shards adı verilen parçalara ayırmakta ve bu parçaları birden fazla sunuculara dağıtarak yüksek performans ve ölçeklenebilirlik sağlamakta ve böylece büyük verilere hızlı erişim ve yüksek kullanılabilirlik sağlamaktadır.
Elasticsearch’ün geniş bir kullanım alanı mevcuttur. Sadece bir arama motorundan ziyade aynı zamanda log analizi, metin madenciliği, veri görselleştirme, iş zekası ve gerçek zamanlı uygulama izleme gibi alanlarda da kullanılabilir. Ayrıca içerik sürecinde inceleyeceğimiz Kibana, Logstash ve Beats gibi diğer araçlar eşliğinde bir ELK(Elasticsearch, Logstash, Kibana) yığını oluşturarak güçlü bir log analizi ve görselleştirme platformu elde edilebilir.
Apache Lucene Nedir?
Apache Lucene, açık kaynak bir text search ve indeksleme kütüphanesidir. Verileri depolamak, indekslemek ve metin tabanlı aramaları gerçekleştirmek için kullanılır. İlk olarak 1999 yılında Doug Cutting  tarafından geliştirilen Apache Lucene, günümüzde Apache Software Foundation bünyesinde geliştirilmekte ve yaygın bir şekilde kullanılmaya devam etmektedir.
Apache Lucene, metin tabanlı arama süreçlerinde bir indeks oluşturarak belgelerin içeriğini parçalara ayırmakta ve bu parçaları anahtar kelimelerine(term) dönüştürerek indekslemektedir. Bu indeksler metin tabanlı sorgulama süreçlerinde etkili bir şekilde arama yapılmasını ve hızlı bir şekilde de sonuçlara ulaşılmasını mümkün kılmaktadır.
Apache Lucene, metin işleme çeşitliliği açısından oldukça zengindir. Metin analizi, kelime köklerini bulma(stemming), eş anlamlı kelimelerin tanınması(synonym recognition), büyük/küçük harf duyarlılığı(case sensitivity), dil analizi(language analysis) vs. gibi özelliklerle metin işleme süreçlerinde işlevsellik gösterebilmekte ve böylece arama süreçlerinde daha doğru ve kapsamlı sonuçlar elde edilmesini sağlayabilmektedir.
Apache Lucene, Java programlama dili ile geliştirilmiş olmasına rağmen diğer programlama dilleriyle de entegre edilebilmekte ve özelleştirilmiş arama motorları, veri görselleştirme araçları, metin madenciliği vs. gibi bu ve bunlara benzer birçok metin tabanlı uygulamaları geliştirebilmemize olanak sağlamaktadır.
Apache Lucene, Elasticsearch arama moturunun temelini oluşturmakta ve güçlü bir arama ve indeksleme altyapısı sunmaktadır. Böylece Elasticsearch, Apache Lucene sayesinde daha kapsamlı bir dağıtılmış arama ve analiz platformu haline gelmiş bulunmaktadır.
Elasticsearch’ün Yetenekleri Nelerdir?
Elasticsearch, bünyesinde birçok yetenek ve özellik barındıran kapsamlı bir dağıtılmış arama ve analiz platformudur. Elasticsearch’ün belli başlı ana yetenekleri şunlardır;
	Full-Text Search (Tam Metin Arama)
Elasticsearch, güçlü tam metin arama yetenekleri ile metin tabanlı belgelerde hızlı ve etkili arama yapma imkanı sağlamaktadır.
	Distributed and Scalable Search (Dağıtılmış ve Ölçeklenebilir Arama)
Elasticsearch, verileri parçalar(shards) halinde bölerek ve bunları multiple nodes adı verilen yapılar üzerinde dağıtarak yüksek performans ve ölçeklenebilirlik elde etmemizi sağlamaktadır.
	Real-Time Data Analysis (Gerçek Zamanlı Veri Analizi)
Elasticsearch’ün gerçek zamanlı analiz yapabilme yeteneğiyle verilerinizi anlık olarak analiz edebilir ve sonuçlar elde edebilirsiniz.
	Aggregations (Toplanan Veri)
Elasticsearch, bir aramadan elde edilen sonuçları gruplandırma, özetleme ve analiz etme yeteneğine sahiptir.
	Distributed Document Storage (Dağıtılmış Belge Depolama)
Elasticsearch, JSON formatındaki belgeleri dağıtılmış bir şekilde depolayarak verilerin güvenliği sağlamakta ve hızlı erişim imkanı sunmaktadır.
	Schema-Free (Şema Özgürlüğü)
Elasticsearch, şema gereksinimleri olmadan verileri depolayabilir ve esnek bir şekilde çalışabilir.
	Data Replication (Veri Kopyalama)
Elasticsearch, veri yedekleme mekanizması ile replica(kopya) oluşturarak yüksek kullanılabilirlik ve veri kurtarma sağlamaktadır.
	Built-in RESTful API
Elasticsearch ile RESTful API’leri kullanarak kolay bir şekilde verilerinizi sorgulayabilir, ekleme, silme ve güncelleme yapabilirsiniz.
	Scalable Analytics (Ölçeklenebilir Analitik)
Elasticsearch, büyük veri kütlelerini hızlı ve ölçeklenebilir bir şekilde analiz edebilme yeteneğine sahiptir.
	Geospatial Search (Coğrafi Arama)
Elasticsearch ile coğrafi verileri depolayabilir ve coğrafi konum tabanlı aramalar yapabilirsiniz.
Bu yetenekler sayesinde Elasticsearch, verilerinizi hızlı bir şekilde indeksleyebilir, arayabilir, analiz edebilir ve gerçek zamanlı sonuçlar elde etmenizi sağlayabilir.
Elasticsearch Arama Motorunun(Search Engine) Operatif Yetenekleri Nelerdir?
Şimdi de Elasticsearch arama motorundaki operatif yeteneklerini masaya yatıralım. Elasticsearch arama motoru temel olarak aşağıdaki operatif yetenekleri barındırmaktadır;
	Full-Text Search (Tam Metin Arama)
Metin tabanlı belgelerdeki anahtar kelimeleri kullanarak hızlı ve etkili bir şekilde arama yapabilme yeteneğidir. Bu özellik, bir metin içinde geçen kelimeleri indeksleyerek verilere erişimi kolaylaştırır.
Elasticsearch’in Full-Text Search özelliği aşağıdaki konuları kapsar;
	Veri	İndeksleme
Elasticsearch, belgeleri indeksleyerek metin verilerini analiz eder ve içeriğin parçalara ayrılmasını sağlar. Bu süreçte, metin ve dil analizi gibi işlemler uygulanır. İndeksleme işlemi neticesinde metindeki kelimeler terimlere(terms) dönüştürülür ve bu terimlerin istatistiksel bilgileri tutulur.
	Terim Eşleştirmesi
Elasticsearch, arama sorgularını belgedeki terimlerle eşleştirir. Bir arama sorgusu girildiğinde, Elasticsearch terimlerin indekslerdeki konumunu bulur ve eşleşen belgeleri geri döndürür. Bu eşleştirme, tam metin arama sorgularını desteklerken aynı zamanda doğru sonuçları getirmek için indeksleme sürecinde yapılan analiz işlemlerini dikkate alır.
	Relevant Sıralaması (Relevancy)
Elasticsearch, full-text aramalarındaki sonuçları relevant(ilgili) sırasına göre düzenlemektedir. Arama sorgusuna göre sonucun eşleşme derecesini belirler ve sonuçları da bu dereceye uygun sırayla döndürür.
	Metin Analizi
Elasticsearch, metin analizi özellikleri sayesinde belgelerin içeriklerini daha iyi anlayabilmektedir. Metin analizi; kelime köklerini bulma(stemming), eş anlamlı kelimelerin tanınması(synonym recognition), büyük/küçük harf duyarlılığı(case sensitivity), dil analizi(language analysis) vs. gibi işlemleri içermektedir. Bu özellikler sayesinde kullanıcıların arama sorgularıyla daha doğru ve kapsamlı sonuçlara ulaşmalarını sağlar.
	Querying (Arama Sorguları)
Kullanıcıların istedikleri bilgilere ulaşabilmeleri için arama moturuna verilen talimatlardır. Elasticsearch, çeşitli sorgu tipleri ve özellikler sunmaktadır. Bunlardan bazıları şunlardır;
	Match	Query
Belirli bir alanın, belirli bir değeriyle eşleşen belgeleri döndürmek için kullanılır. Örneğin; ‘title’ alanında ‘elma’ kelimesini içeren belgeleri getirmek istediğimizde Match Query’den istifade etmekteyiz.
	Term	Query
Belirli bir alanda, belirli bir terimle tam olarak eşleşen belgeleri döndürmek için kullanılır.
	Range	Query
Belirli bir alanın, belirli bir değer aralığında bulunan belgeleri döndürmek için kullanılır. Örneğin; ‘price’ alanı 10 ile 100 arasında olan belgeleri getirmek istediğimizde Range Query’den istifade etmekteyiz.
	Bool	Query
Birden fazla sorguyu birleştirerek karmaşık mantıksal sorgular oluşturmak için kullanılır. Bool sorgusu, ‘must'(kesinlikle eşleşmeli), ‘should'(isteğe bağlı eşleşmeli) ve ‘must_not'(kesinlikle eşleşmemeli) bölümlerini içerebilir.
	Match	Phrase	Query
Tam cümle araması yapmak için kullanılır. Aranan ifadenin tamamını içeren belgeleri getirir. Örnek olarak; ‘sebepsiz boş yere ayrılacaksan’ cümlesini içeren belgeleri getirmek istediğimizde Match Phrase Query’den istifade edebiliriz.
	Wildcard Query
Joker karakterleri kullanarak belirli bir desene uyan belgeleri getirmek için kullanılır.
	Aggregations
Arama sonuçlarını gruplandırmak ve istatistiksel verileri elde etmek için kullanılır. Örneğin; belgeleri kategoriye göre gruplama ve her kategorinin ortalama fiyatını bulmak istiyorsak eğer Aggregations’dan istifade edebiliriz.
	Filtering (Filtreleme)
Arama sonuçları üzerinde istenmeyen sonuçları elemek amacıyla belirli kriterlere göre filtreleme işlemi için kullanılan özelliktir. Elasticsearch, aşağıdaki gibi bazı çeşitli filtreleme seçenekleri sunmaktadır;
	Term Filter
	Range Filter
	Bool Filter
	Exists Filter
	Geo Distance Filter
	Ranking (Sıralama)
Arama sonuçlarını belirli bir kriter veya algoritma kullanarak, arama deneyimini iyileştirmek amacıyla önem sırasına göre düzenlemek için kullanılan bir yetenektir. Elasticsearch, aşağıdaki gibi çeşitli sıralama yöntemleri ve stratejileri sunmaktadır;
	Relevance Ranking
Elasticsearch, varsayılan olarak TF-IDF(Term Frequency-Inverse Document Frequency) tabanlı bir relevance sıralaması kullanmaktadır. Bu sıralama yöntemi, bir belgedeki terimin geçme sıklığına ve genel koleksiyondaki nadirliğine dayanır. Bu sayede, arama sorgusunun içerdiği terimlerin belgedeki önemini belirler.
	Field-Based Ranking
Belirli bir alanın değerine veya skoruna göre sıralama yapma imkanı sunan yöntemdir. Misal olarak; fiyat alanına göre artan yahut azalan şekilde sıralama bu yöntemle gerçekleştirilebilir.
	Geo Ranking
Coğrafi konum bilgilerini kullanarak, belirli bir konuma göre sıralama yapmayı sağlar. Örneğin; kullanıcının mevcut konumuna en yakın noktalardan başlayarak sıralama yapabilir.
	Time-Based Ranking
Belirli bir zaman aralığı veya tarihe göre sıralama gerçekleştirilebilir. Misal olarak; en son güncellenen veya en yeni belgeler üst sıralara taşınabilir.
	Custom Ranking
Elasticsearch, kullanıcının kendi sıralama mantığını uygulayabilmesi için özel sıralama stratejileri oluşturmasına olanak tanır. Bu, belirli kriterlere dayalı olarak özel bir puanlama veya sıralama algoritması kullanılmasını sağlar.
	Autocomplete (Otomatik Tamamlama)
Kullanıcılara arama yaparken istedikleri terimi veya ifadeyi hızlı bir şekilde tamamlama ve öneriler sunma yeteneğidir. Bu özellik sayesinde, kullanıcıların doğru terimleri hatırlamalarına veya tamamlamalarına yardımcı olarak arama süreci hızlandırılmakta ve kullanıcı deneyimi iyileştirilmektedir. Elasticsearch, otomatik tamamlama özelliğini gerçekleştirmek için aşağıdaki gibi çeşitli yöntemler sunmaktadır;
	Completion Suggester
Elasticsearch, completion suggester adı verilen özel bir veri yapısı ve sorgu tipi kullanarak otomatik tamamlama işlevselliği sağlamaktadır. Bu yöntemde, tamamlanacak terimlerin bir ‘tamamlama alanı’ içinde saklanması gerekir. Kullanıcı her karakter girdiğinde, Elasticsearch bu alanı tarar ve kullanıcıya olası tamamlama önerileri sunar.
	Fuzzy Matching
Elasticsearch, otomatik tamamlama sırasında karater tabanlı benzerlik eşleştirmesi yapabilen fuzzy matching(bulanık eşleştirme) özelliğini de desteklemektedir. Bu sayede, kullanıcının yanlış yazılan veya hatalı karakterler içeren terimlere rağmen doğru tamamlama önerileri alması sağlanır.
	Contextual Suggestions
Elasticsearch, kullanıcının arama bağlamına bağlı olarak öneriler sunabilme yeteneğine sahiptir. Örneğin; kullanıcı bir kategori seçtikten sonra sadece o kategoriye ait tamamlama önerilerini göstermek gibi…
	Öneri Sıralama
Elasticsearch, tamamlama önerilerini belirli bir sıralama kriterine göre düzenleme imkanı sunmaktadır. Örneğin; popülerlik, alfabetik sıralama veya özel bir sıralama mantığına göre sıralama yapılarak otomatik tamamlama gerçekleştirilebilir.
	Spell Correction (Doğru Yazım Düzeltme)
Elasticsearch’te spell correction, kullanıcıların hatalı veya yanlış yazılmış kelimeleri otomatik olarak düzeltmelerine olanak tanıyan bir özelliktir. Böylece bu özellik, kullanıcıların doğru yazımı hatırlamalarına veya hatalı yazılan kelimeleri düzeltmelerine yardımcı olur. Bu özellik için Elasticsearch’de kullanılan bazı yöntemler aşağıdaki gibidir;
	Fuzzy Matching (Bulanık Eşleştirme)
Autocomplete özelliğinde olduğu gibi spell correction özelliğinde de hatalı yazılmış kelimeleri düzeltmek için fuzzy matching algoritması kullanılabilmektedir. Bu algoritma ile kelimenin benzerlik derecesine göre düzeltilmiş bir versiyonu önerilebilir. Örneğin; ‘housse’ yerine ‘house’ kelimesini önerebileceği gibi…
	Distance-Based Approaches (Mesafe Tabanlı Yaklaşımlar)
Elasticsearch, hatalı yazılmış kelimenin doğru yazımını bulmak için distance-based metrikleri kullanabilir. Levenshtein Mesafesi veya Damerau-Levenshtein Mesafesi gibi yöntemler kullanılarak hatalı yazılan kelimenin doğru yazıma en yakın olanını seçer.
	Dictionary-Based Approaches (Sözlük Tabanlı Yaklaşımlar)
Elasticsearch, bir kelime sözlüğü veya sözcük listesi kullanarak doğru yazımları kontrol eder. Hatalı yazılmış kelimenin sözlükteki bir kelimeyle eşleştiği durumlarda düzeltme yapar. Bu yöntem, önceden belirlenmiş bir kelime listesini kullanır ve doğru yazımları belirli bir kaynaktan alır.
	Customization (Özelleştirme)
Elasticsearch, kullanıcıların kendi doğru yazım düzeltme kurallarını veya sözlüklerini tanımlamalarına izin verir. Bu şekilde, kullanıcılar hedef kitlelerine veya belirli kullanım senaryolarına uygun düzeltmeler yapabilir.
	Indexing (İndeksleme)
Elasticsearch’de indexing özelliğini, verileri Elasticsearch’e kaydetme ve bu verilerin etkili bir şekilde aranabilir ve erişilebilir hale gelmesi için indekslenmesi olarak düşünebilirsiniz.
	Faceted Search
Kullanıcılara arama sonuçlarını daha iyi anlamaları ve istedikleri sonuçlara daha hızlı ulaşabilmeleri için arama sonuçlarını filtrelemek ve kategorize edebilmelerine olanak sağlayan yapılandırılmış bir arayüz sağlar.
Elasticsearch Stack Nedir?
Elasticsearch Stack, Elasticsearch’ü temel alarak oluşturulan ve Elasticsearch’ün yeteneklerini genişletmek için onun çevresinde konuşlandırılmış farklı bileşenlerden bir bütünü ifade eden temel kavramdır. Bu bütünün içerisinde; verilerin toplanması, işlenmesi, depolanması, görselleştirilmesi ve yönetimi gibi farklı alanlarda işlevselliği artırmak için türlü bileşenler mevcuttur.
Elasticsearch Stack’in temel bileşenleri; Elasticsearch’ün ta kendisi olmakla beraber, Kibana, Logstash, Beats ve Elasticsearch Machine Learnin olmak üzere beş adettir diyebiliriz. Şimdi bu bileşenleri tek tek izah etmemiz gerekirse eğer;
ElasticSearch 5 temel özellik
NoSQL modele sahip bir veritabanı olması. Bununla beraber şemadan bağımsız olması. Diğer NoSQL veritabanlarında olduğu gibi verileri JSON formatında saklıyoruz. NoSQL şemadan bağımsız olduğu için istediğimiz satırda istediğimiz kadar veri tutabiliyoruz. Bir sütunda int diğerinde decimal değer tutarız.
Stuctured ve unstructured veri üzerinde arama yapabilmesi. Stuctured data boolean,int,string datalardır. Unstructured data ise elasticsearch’ün uzmanlık alanı olan kısım. Büyük text dosyaları bu kategoriye girer.
Elasticsearch ile iletişime geçmek için REST mimarisini kullanıyoruz. http istekleri üzerinden GET,POST,PUT,DELETE ile haberleşebiliriz. Postman üzerinden de haberleşebiliriz.
Son iki maddemiz olan shards ve replicas'lara biraz ayrıcalık tanıyacağız. Çünkü makalenin odak noktası olarak onları belirledim. Sonraki bölümlerde detaylarıyla diğer maddelere de değineceğiz.
1.	Node
2.	Cluster
3.	Index
4.	Type
5.	Mapping
6.	Document
7.	Shard ve Replica
Bazı yabancı kaynakları incelerseniz node'lardan önce cluster'ları incelediklerini görebilirsiniz. Bu gerçekten garibime gidiyor. Neden mi? Aşağıda değindim. Haydi başlayalım.
Node
Bir server üzerine kurduğumuz ve sonraki makalelerimizde göreceğimiz document'larımızı index'leyip, üzerlerinde query'ler çalıştıracağımız tek bir elasticsearch instance'ına verdiğimiz isimdir. Buna örnek olarak bir önceki makalemizde ubuntu server üzerine kurduğumuz elasticsearch instance'ını verebiliriz. Kendileri bir node olurlar. 
Kurduğumuz bir node özellikle müdahele etmediysek random bir isim alır. Elasticsearch geliştiricileri random bir string vermektense Marvel karakterlerinden bir tanesini random seçerek atanmasını sağlamışlardır. Hatta gelin bir önceki makalede kurduğumuz elasticsearch node'unun ismine bir bakalım.
Bunun için /_nodes endpoint'ine HTTP GET request atmamız yeterli olacaktır. Sense yardımıyla bir request atalım ve node'umuza Marvel karakterlerinden atanan ismi görelim.
Beklentim bir Hulk idi fakat ilk defa duyduğum Balthakk ismi ile karşılaştım 
Eğer sonraki alt konuda inceleyeceğimiz gibi bir cluster'ımız varsa ve çok fazla node üzerinde çalışıyorsak yönetilebilirlik açısından default isimler yerine bizim vereceğimiz isimleri tercih etmek durumunda kalabiliiz. Bir node'un ismini sadece bir HTTP POST ile sonradan değiştirebiliyoruz. REST API'lar üzerine kurulu olmasının bir faydası daha! 
Dikkatinizi bir de resimdeki ilk key'lerden cluster_name'e çekmek isterim. Bu da node'un dahil edileceği cluster ismimiz. Eğer aynı network'de birden fazla cluster'ımızda varsa default cluster ismi yerine yine kendimiz bir cluster ismi vermek durumunda kalabiliriz diyelim ve şimdi cluster ile konumuza devam edelim.
Cluster
IT sektöründeki çoğu terim Türkçe'ye çevrildiklerinde asıl anlamlarını yitirirler. Ama cluster onlardan biri değil. Küme, demet olarak çevrilebilen cluster Tükçe olarakta gayet anlaşılır olabiliyor. Cluster bir veya birden fazla elasticsearch node'unu içerisinde barındıran yapılardır. Fakat bir cluster içerisinde tutacağımız node'lar rasgele document'lar içeren node'lar olamazlar. Kesinlikle ve kesinlikle aynı amaca hizmet etmeye çalışan, index, routing ve schema'ları aynı olan node'lar olmak durumundadır.
Çünkü bu gereksinimin ve cluster'ların amacı gerektiğinde failover yaparak birbirleri yerine geçebilmek ve(ya) toplam yükü paylaşarak distribute edebilmek. Bakın bu terimleri çeviremedim işte. Ama failovering ve distributing için bazı örnekleri aşağıda ve sonraki makalelerimizde beraber yine inceliyor olacağız.
Bir cluster kurmak için node'larda yaptığımız gibi kurulumlar ile uğraşmanıza gerek yoktur. Çünkü fiziksel olarak nitelendirebileceğimiz bir olgu değildirler. Bir nevi node'ları gruplandırmak gibi düşünebiliriz. Bazı node'ları A cluster'ına bazılarını B cluster'ına dahil etmek için yapmamız gereken tek şey kurulu olan node'ların cluster_name'lerini değiştirmektir.
Default olarak bu değer elasticsearch olarak atanır. Eğer bir network - domain üzerinde birden fazla cluster'ınız olacaksa mutlaka benzersiz cluster isimleri seçmelisiniz. Bir de her bir cluster için bir den fazla ortamınız varsa bunlar içinde benzersiz isimler belirlemeniz gerekir. İlk aklıma gelen örnekleri paylaşmak isterim;
1.	dev
2.	preprod
3.	prod
Biraz geleneksel oldu ama sizlerinde aklına bunların geldiğine eminim 
Index
Node ve Cluster'dan sonra biraz daha üst katmanlara çıkalım. Şimdi sırada Index'ler var. Eğer relational database'lerdeki karşılığına bakmak istersek Index'leri bir database (catalog)'a benzetebiliriz. Ya da benzer karakteristik özelliklere sahip document'ları içerisinde bulunduracak bir collection'a da. Bir node içerisinde 0 veya daha fazla Index bulunabilir. İsimleri benzersiz ve lowercase olmak zorundadır. 
Bir index yaratmak için sadece index'in yaratılacağı bir HTTP POST request yapılabileceği gibi, hiç yaratılmamış bir index ve type içerisine document eklenmeye çalışıldığında da yaratılması elasticsearch engine'e bırakılabilir.
Makalemizin başında asıl odaklanacağımız noktaların Shard'lar ve Replica'lar olacağından bahsetmiştik.
Özellikle belirtilmediyse bir index'in default olarak 5 primary shard'ı ve 1 replica shard'ı bulunur. Özellikle belirtilecekse de bir index'in en az 1 primary shard'ı ve en az 0 repliaca shard'ı bulunmak zorundadır.
Type
Index'lerin altında tanımlanabilecek ve içerisinde documant'ları barındıracak birimlerdir. Relational database'lerdeki karlşılığı tablolara / partition'lara denk gelir. Index'lerde olduğu gibi sınırı yoktur ve isimleri lowercase olup kendi aralarında benzersiz olmak zorundadırlar.
Mapping
Index'ler altında tanımlanacak olan Type'ların nasıl field'lara sahip olacağı ve bu field'larda ne gibi analyzing işlemlerinin yapılacağı bilgisini taşırlar. Bunu relational database'lerdeki column type, relation, index vs. tanımlamalarına benzetebiliriz.
Full text search ya da elasticsearch'ün desteklediği diğer özellikler kullanılacaksa hangi alanların hangi analyzer ile tokenize edileceğini mapping'ler ile bildirilir.
Document
Ve sonraki makalelerde en çok kullanacağımız noktaya geldik. Document'lar aslında Index içerisindeki Type'larında içinde barındıracağımız ve üzerlerinde CRUD işlemleri gerçekleştireceğimiz birimlerdir.
Relational database'deki karşılıkları tablo içerisinde tuttuğumuz verilerdir. Index, Type ve Document için hep relational database'lerdeki karşılığı olabilecek noktalardan örnekler vermeye çalıştım. NoSql engine'ler ile ilk defa tanışan okurlarımın daha iyi anlayabilmelerinden başka amacım yok :)
Örneğin kendi blog sitemden örnek göstereyim. Tabi ki üzerinde devasa search query'ler çalıştırmadığım için bir NoSql çözüme ihtiyaç duymadım. Bu blogta örnek gösterebileceğim Blog adında bir database (catalog) olması, içerisinde Blogs, Categories, Comments gibi tabloların bulunması ve her bir tablonun schema-full olup içerisinde verilerin bulunmasıdır.
Eğer bu blog için relational database değilde elasticsearch gibi bir NoSql çözüm kullansaydım bunların karşılığı tamda şöyle olacaktı;
Blog adında bir Index ve içerisinde tanımlanmış Blogs, Categories, Comments adlarında birer schema-less Type (ve mapping'leri) ve her bir Type'ın içerisinde ise her ne kadar schema-less olsada büyük ölçüde benzer field'lara sahip document'lar olacaktı.
Shard ve Replica
Şu alt konuya geldiğimde nasıl bir başlangıç yapmam gerektiğini bir türlü belirleyemedim çünkü bu iki yapının önemini anlatabilecek sözleri tam olarak seçemiyorum. Anlatımı kullanımından daha kolay. Fakat bazı noktalarda değiştirilemeyen yapılar içerdiği için büyük data'lar içerecek olan bir cluster'ımız varsa son derece dikkatli davranmalıyız.
Shard'lar store edilmiş olan document'ların tutulduğu küçük birimlerdir. Her bir shard aslında birer lucene instance'ına tekabül eder. Daha önce bahsettiğimiz gibi bir Index'in kaç adet shard'a sahip olacağını özellikle belirtmediysek bizler için 5 adet shard yaratılır. Peki bu 5 adet shard aynı data'ları mı içerir?
Hayır! Bir index yarattığımızı ve 1000 adet document store ettiğimizi düşünelim. Bu durumda elasticsearch yaratılan 5 shard'a eşit bir şekilde bu document'ları distribute edecektir (dağıtacaktır).
Şimdi de store ettiğimiz bu 1000 adet document'ın bir field'ına göre search yaptığımızı düşünelim. Aradığımız tüm document'ların aynı shard'da store edildiklerinden emin olamayız. Bu nedenle request'i alan elasticsearch engine paralel olacak şekilde tüm shard'lar üzerinde bu searching işlemini gerçekleştirir ve tüm shard'lar cevap verdikten sonra hepsini concat ederek bize sunar. Her bir shard'ın birer lucene instance'ı olmasının faydasını bu noktada görüyoruz. Çünkü aynı node üzerinde dahi birden fazla shard varsa kendi aralarında paralel olarak çalıştırılabilirler.
Birde replica shard'lara göz atalım. Daha önce belirttiğimiz gibi biz özellikle belirtmedikçe her bir Index'in 1 replica shard'ı vardır. Aslında bu 1 adet replica shard anlamına gelmiyor. Bu söz konusu index içerisindeki her bir primary shard için 1 adet replica shard anlamına geliyor. Replica shard'lar primary shard'ların aksine, söz konusu primary shard'ın içerdiği document'ların birebir kopyasını içerir. Bu da kullandığımız mimari için yatayda failovering ve scaling imkanları sağlayacaktır.
Dilerseniz bunu biraz açalım. Yine 1000 adet document'ın 5 primary shard'a bir node üzerinde distribute edildiğini düşünelim. Ardından aynı cluster'a bir başka node daha ekleyelim. Yani aynı network / domain içerisine dahil edilmiş bir sunucu ve içerisinde kurulu elasticsearch engine'i. Bu durumda 1. node'da ki 5 primary shard 2. node ile paylaşılacaktır. 2,5 birine 2,5 birine paylaşması söz konusu olmadığı için 2-3 ya da 3-2 olacak şekilde bir paylaşım söz konusu olacaktır 
Şöyle betimleyebiliriz;
1. Node : S1   S2   S3
2. Node : S4   S5
Primary shard'lar için durum böyle. Bir de her bir primary shard'ın birer replica shard'ı olduğundan ve bire bir aynı data'yı içerdiklerinden bahsettik. Şimdi konu dışında bir soru sormak isterim size. Bilgisayarımızda 2 adet hard-disk'in olduğunu düşünelim. Siz 1. hard-disk'in yedeğini alıp 1. hard-disk'te tutmak ister misiniz? Bu hiç de tutarlı bir çözüm olmayacaktır. Bu nedenle primary shard'lar node'lar arasında paylaştırılırken, söz konusu replica shard'lar aynı document'ları tuttuğu primary shard ile aynı node üzerinde barındırılmazlar. Yani aşağıdaki gibi bir paylaşım olur;
1. Node : S1   S2   S3   R4   R5
2. Node : S4   S5   R1   R2
Böyle bir mimarimiz mevcut iken herhangi bir node'un down olması halinde ayakta kalmış olan node'daki replica shard'lar birer primary shard'a dönüşecek ve consistency bozulmadan cluster'a gelen request'ler yine karşılanabilecektir. Pek tabi artık bir node'umuz mevcut olduğu için bu node'u kaybetmememiz gerekir. Elasticsearch'ün sağladığı failover avantajlarından biri bu idi.
Scaling'e az önce biraz değinmiş olduk zaten. Elimizde 1000 adet document ve 5 primary shard var iken bunu tek bir node'da değil, aynı cluster'da farklı bir node ile distribute ettik. Bu da bir machine üzerindeki I/O işlemlerini azaltacak ve primary shard'ların kendi aralarında paralel işletildiği gibi node'larında kendi aralarında paralel işletilmesini sağlayacaktır.
Aynı zamanda bir node üzerindeki primary shard içerisinde (diğer bir değiş ile lucene instance) tutabileceğimiz document sayısı sınırlıdır. Tabi bu sınıra ulaşmak oldukça kolay değil çünkü bu sınır 2,147,483,519 olarak belirtilmiştir. 
Umarım primary shard ve replica shard'lar için verdiğim bu örnek anlaşılır olmuştur. Söylediğim gibi bazen karmaşık bir hal alabiliyorlar. Planladığım başka bir makalede elimizdeki donanımsal kaynak ve barındıracağımız document sayısı / ivmesine göre nasıl bir hesaplama yapmamız gerektiğini anlatmayı planlıyorum.

Elasticsearch ücretli paketler
Enterprice Search,Observability,Security. 
ElasticSearch Enterprice Search : Google Drive’ınız var. Şirkette herkes oraya dosya atıyor. O dosyalar arasında arama yapmanız gerekiyor. Web sayfasında yüzlerce dökümanınız var. Burada arama yapmak istiyorsunuz. 
Elasticsearch Observability : Cluster oluşturduğumuzda cluster içerisinde olan değişiklikleri gözlemliyor.
Security: http üzerinden haberleşiyoruz. https üzerinden değil. Cluster elastic üzerinden yapıldığında 3 özellik geliyor. Ama manuel bir kurulum gerçekleşirse bu özellikleri kullanmak için gereken konfigürasyonları kendimiz ayarlayacağız.
Document : Indexlenmiş en basit bilgi.
Index: birbiri ile ilişkili dökümanlara verilen isim olarak düşünebilirsiniz. Indexleme kaydetme anlamına geliyor. Kayıt işlemi yapılırken hem hali hem de indexlenmiş hali saklanır.
Data Stream: Zaman temelli data. Log kayıtlarının günlük tutulduğunu varsayalım. 12/12,13/12,14/12 gibi. Bunları tek bir başlık altında toplayarak bir takma isim verebiliyoruz.
Shard: Dataları tutan 1.componentimiz.Shardlara gelen veri segment adı verilen yapılara ayrılıyor ve kaydediliyor. Segmentlere verinin orijinal halini kaydediyor. Inverted indexlere değişiklik yapılmış veriler kaydediliyor.
Replicate: Shardların tam bir kopyası. Bir shardın birden fazla node’da replicate’i yer alır. Herhangi bir node çökse bile başka nodelarda yer alan replicate ile o shard tamamlanır. 
Text Analyzing: text temelli gelen dosya önce bir analiz sürecinden geçer. Analiz sürecinden geçerken süreç içerisinde 2 aşama daha vardır. Birisi tokenization diğeri de normalization. Analiz sürecinden geçirmesi için verinin tipinin text olması gerekmektedir. String,int,double değerler olursa bu süreçten geçmez.
Tokenization: Untokenized string => Bugün çok sıcaktı. Sıcak havalarda çalışılmaz.
Tokenized string => Bugün ,çok, sıcaktı, Sıcak, havalarda, çalışılmaz
Normalization => Tokenization işlemi gerçekleştirilen yapı eş anlamlı ya da kök cümleler ile zenginleştirilir.
Sıcaktı => Sıcak(Kök)
Havalarda=>Hava(Kelime kökü)
İsim => Ad(eş anlamlı) gibi.
Inverted Index
Tokenization ve normalization aşamasından geçen verilerin kaydedildiği yer.Aşamaları ise aşağıdaki gibidir.
<h1>Kırmızı kitap</h1>
HTML strip filter => Kırmızı kitap
Whitespace Tokenizer => [Kırmızı,kitap] (whitespace boşluğa göre. Nokta,virgül de olabilir.)
Lowercasing Tokenizer [kırmızı,kitap]
Inverted Index ile bir kelimenin ne sıklıkla kullanıldığı(frekans) da tutulur.
Örn: kırmızı kitap kırmızı kalem
Kırmızı => 2
Kitap => 1 
Kalem => 1
Relevancy: 
Elasticsearch için bir ilişki skor değeridir. Aranan kelime ile o kelimenin arasındaki ilişkiyi benzerliği gösterir. Alakalı ve alakasız sonuçlar relevancy değerine göre sıralanıyor.(BM25 algoritmasına göre üretilen)
Elasticsearch Container olarak ayağa kaldırma
Tek tek ayağa kaldırmaktansa docker compose ile ayağa kaldıracağız.VS Code’da docker-compose.yml ile ayağa kalkacak.
Docker-compose.yml
version: '3.8'
services:
  elasticsearch:
    image: docker.elastic.co/elasticsearch/elasticsearch:8.7.1
    expose:
      - 9200
    environment:
      - xpack.security.enabled=false
      - "discovery.type=single-node"
      - ELASTIC_USERNAME=elastic
      - ELASTIC_PASSWORD=DkIedPPSCb
    networks:
      - es-net
    ports:
      - 9200:9200
    volumes:
      - elasticsearch-data:/usr/share/elasticsearch/data
  kibana:
    image: docker.elastic.co/kibana/kibana:8.7.1
    environment:
      - ELASTICSEARCH_HOSTS=http://elasticsearch:9200
    expose:
      - 5601
    networks:
      - es-net
    depends_on:
      - elasticsearch
    ports:
      - 5601:5601
    volumes:
      - kibana-data:/usr/share/kibana/data
networks:
  es-net:
    driver: bridge
volumes:
  elasticsearch-data:
    driver: local
  kibana-data:
    driver: local

docker-compose up ayağa kaldırıyor.
Docker-compose stop durduruyor.
Docker-compose down siliyor.
API
Indexing,Searching,Reading,Updating,Deleting
PUT products/_doc/1
{
  "name":"Iphone 14",
  "rating":8.5,
  "publish":true,
  "category":"mobile phones",
  "price":{
    "usd":2500,
    "eur":2000
  }
}
{
  "_index": "products",
  "_id": "1",
  "_version": 4, //Kaç update işlemi yapıldığını sayıyor.
  "result": "updated",//Hangi operasyonun gerçekleştirildiği gösteriliyor.
  "_shards": {
    "total": 2,
    "successful": 1,
    "failed": 0
  },
  "_seq_no": 5,//Toplamda kaç operasyon yapıldığı gösteriliyor.
  "_primary_term": 1
}
GET products/_doc/2
{
  "_index": "products",
  "_id": "2",
  "_version": 2,
  "_seq_no": 3,
  "_primary_term": 1,
  "found": true,
  "_source": {
    "name": "Iphone 15",
    "rating": 9,
    "publish": true,
    "category": "mobile phones",
    "price": {
      "usd": 3500,
      "eur": 3000
    }
  }
}
GET products/_source/1
{
  "name": "Iphone 14",
  "rating": 8.5,
  "publish": true,
  "category": "mobile phones",
  "price": {
    "usd": 2500,
    "eur": 2000
  }
}
HTTP PUT metodunda eğer o id’li değer yoksa kaydeder var ise günceller.

 
Update
POST products/_update/1
{
  "doc": {
    "name":"Nokia 3310"
  }
}
Update işlemi post ile yapılıyor. Put ile update işleminde _update kelimesini ekleyemiyoruz. Put ile update yapmak istersek put products/_docs/1 yazdığımızda id’si 1 olan değer var ise update ediyor. Yok ise id’si 1 olan bir değer oluşturuyor.
Delete
DELETE products/_docs/2 diyerek silme işlemini gerçekleştiriyoruz. Olmayan bir id’ye sahip değeri silmeye çalışırsak not found hatasını alacağız.
HEAD Metot Tipi
Head metot tipiyle data var mı yok mu kontrolünü sağlayabiliyoruz. HEAD metodu ile body içerisinde var mı yok mu mesajı aramak yerine sadece başlıkla var ya da yok diye mesaj dönüyor.
Birden fazla veri çekmek istersek ya da tüm verileri çekmek istersek
Id değeri 1 ya da 2 olan veriler gelsin
GET products/_mget
{
  "ids":["1","2"]
}
Tüm veriler gelsin dersek 20’şer şekilde gelir. Pagination yapar.
GET products/_search
{
  "query": {
    "match_all": {}
  }
}
Custom response with no metadata
GET products/_source/1 ID’si 1 olan datanın sadece metadatasını getiriyor.
Custom response with _source_includes or _source_excludes
Id’si 1 olan değerin name,rating,category kısımlarını getir.
GET products/_doc/1?_source_includes=name,rating,category
Id’si 1 olan değerin name,rating,category propertyleri dışındakileri getir.
GET products/_doc/1?_source_excludes= name,rating,category
DATA TYPES
Common Types
Text: string value , Log message,blog content, product description, product title gibi örnek kullanımları var.
Keyword: Bu textler analiz sürecinden geçmez. Tokenization,normalization sürecinden geçmez.

Full Text Search => Büyük text verisi içeren kolonlarda ya da dökümanlarda aratılmak istenen kelimeyle textin içeriğini kıyaslayarak gerçekleştirilen bir arama metodudur. Yaygın olarak web arama motorlarında ve bilgisayar local sürücülerinde kelime yoluyla yapılan aramalarda kullanılır. 
Veritabanları temelde dikeyde arama yapmak için optimize edilmişlerdir. Bu da satırlar üzerinde arama yapılacağı anlamına gelir. Fakat sunucularda tutulan veriler her zaman satırlarda tutulmaya uygun olmayabilir. Satırlar içerisinde tutulan veri içinde sorgu yapmak veri ne kadar büyük olursa olsun index ya da partition gibi metotlarla hızlı biçimde gerçekleştirilir.
Uzun bir metin parçasını düşündüğümüzde ise durum farklıdır. Artık elimizde satır satır indekslenebilir bir veri yerine, birbiri ardına dizilmiş kelimeler, hatta karakterler yer almaktadır. Bu durumda, aramak istediğimiz text desenini karakter karakter ilerleyerek sorgulamamız gerekirdi. Dolayısıyla, buradaki uzun metni oluşturan kelimelerin her birini bir satır olarak düşünüp, dikey bir yapıda indeksleyebilirsek, en performanslı arama yöntemine ulaşabiliriz.
Full text search arama motorlarında ve web sayfalarında en çok kullanılan arama metotlarından biridir. Aranan ve indexlenmiş olan her sayfa, arama kelimesi ile eşlenme durumunda indexler üzerinden gösterilir. 
Full text search uygulamaları çoğunlukla inverted index kullanılır. Inverted index text tabanlı döküman kümesi içindeki terimlerin hangi dökümanların ilişkili olduğunu tutarak, aramaları bu terimler içinde yaparak terimler üzerinden dökümanlara ulaşmayı sağlayan bir index yapısıdır.
Elastic Search Engine => Unstructured ve structured data üzerinde arama yapabiliyor. 
Unstructured Data => medya ve eğlence verileri, gözetleme verileri, coğrafi-uzamsal veriler, ses , dökümanlar(fatura,email...), IoT(sensör verileri) vb...
Structured Data => Kullanıcların ya da yazılımların hızlı etkileşimi için bir standarda sahip olan veri topluluğuna denir. Structured data bir table ve o table içerisinde adı,adresi ve telefon numarası gibi veriler saklayan yapıdır.DateTime,boolean,string,int veri tipleri.
	Fazla yük geldiğinde kendisini yatayda ölçeklendirebiliyor.
	En önemli gücü indexleme. 
High Availability
High Availability => yüksek erişilebilirlik , sistemin veya servisin sürekli olarak erişilebilir olmasını ifade eder. Elasticsearch high availability’i sağlamak için;
Cluster yapısı: Veriyi birden fazla düğüme dağıtan bir küme yapısında çalışır. Küme, bir veya daha fazla master düğüm ve data düğümlerinden oluşur. Bu yapı bir düğüm arızalansa bile verinin başka düğümlerden hala erişilebilir olmasını sağlar.
Replication: Her bir indexi birden fazla kopyası alınır. Eğer bir düğüm devre dışı kalırsa replikalar üzerinden veri ve hizmet erişimi devam eder.
Automatic Node Failover: Bir düğüm arızalandığında otomatik olarak bu düğümdeki görevleri diğer düğümlere devreder.
Fault Tolerance
Hata toleransı sistemin bir kısmı arızalansa bile hizmetin devam edebilmesini ifade eder. 
Shard’lar ve Replikalar: Veriler shard adı verilen parçalara ayrılır ve bu shard’ların replikaları farklı düğümlere dağıtılır. Eğer bir shard veya düğüm arızalanırsa replikalar devreye girer ve veri kaybı yaşanmadan işlem devam eder.
Master düğüm yedeklemesi: Elasticsearch kümesi bir veya daha fazla master düğümüne sahip olabilir. Eğer aktif master düğüm arızalanırsa yedek master düğümlerden biri devreye girer.
Snapshot ve Yedekleme: Periyodik olarak veri yedekleme snapshot almayı destekler.
High Availability ile Fault Tolerance Arasındaki Fark Nedir? 
High availability sistemde bir sıkıntı meydana geldiğinde bir yavaşlama olur ama çalışmaya devam eder.  Fault tolerancı yüksek olduğunda sistem kendini onarır ve sistemde herhangi bir yavaşlık olmaz.
Elastic Stack
Elasticsearch ile birlikle kullanılan komponentleri tanıyacağız.
Kibana: Bir UI’dır. Nodejs ile yazılmıştır. Service içine yazılan veriler üzerinde arama yapmamıza olanak veren UI’dır. Shard’lar oluşturmaya da imkan tanıyor. Kibana query language ile sorgular yazabiliyorsun. Yazdığın sorgu elasticsearch’ün REST API’leri ile haberleşiyor. Elasticsearch SQLServer ise Kibana SQLServer Management Studio’dur. Toplanıp anlamlı hale gelen verinin, analizini yaptıktan sonraki görselleştirme işlemini yapar.
LogStash: Dataları işleme motoru . Çeşitli kaynaklardan gelen verileri örneğin loglama işlemlerini ya zengineştiriyor ya filtreliyor ya da yok ediyor. Ve işleme tabi tuttuğu dataları elasticsearch service gönderiyor.
Beats: Dataları toplama işlemini gören bir component. Filebeat kurulduğunda log dosyalarını bir file’a yazıyor.
Filebeat=> loglama işleminin sonuçlarını dosyalara yazıyor. O dosyadakileri alıp logstash’e gönderiyor.
Metricbeat => serverda ne kadar cpu ram kullanıldı. Bu bilgilere erişiyorsunuz.
Heartbeat => Uygulamanın ayakta olup olmadığını sürekli kontrol ediyoruz.
Elasticseach’ün Genel Özellikleri
NoSQL model bazlı arama motoru, Unstructured ve structured verilerde arama yapma olanağı, Schema şartı yok(Json verilerde arama olanağı), communication için Restful
ElasticSearch Architecture
Document: bir data kaydetmek istediğimizde bu data ES için document.ES tarafından indexlenen en küçük bilgi. İlişkisel veritabanlarında satırın buradaki karşılığı document. Kaydedilecek dosyanın formatını ES Json olarak bekler. Kaydederken zaten ES’lerin endpointlerini kullanıyoruz. 
Index: ES’ de birbirileri ilişkili documentlara index denir. ES cluster içerisinde farklı virtual machine’lere dağılmış durumda. Farklı vm’lere dağılmış ES cluster içerisinde biz bu birbiri ile ilişkili dcoumentleri isimlendirmek için index kavramını kullanıyoruz.
Data Stream: ES’de zaman temelli data demek. Sürekli log üreten bir sistemde tek bir log index oluşturmak yerine her gün için ayrı index tablosu oluştursa oldukça fazla index tablomuz oluşacak.  60 günden fazla olan index dataları sil dersek çok kolay bir şekilde silebiliriz.  Bir takma isimle birden fazla log index tablolarını tek bir çatı altında topluyoruz.
Cluster: Node’ların bir araya gelerek oluşturduğu yapı. 3 node’lu cluster 4 node’lu cluster gibi bir tabir cluster’ın içerisinde kaç sanal makine olduğunu açıklıyor.
Node: Bizim sanal makinelerimiz.Her bir sanal makine içerisinde ES instance var. 
Shard: Shard’lar asıl datayı tutan componentlerdir. Asıl datayı tutan 1.componenttir. Farklı shardlarda tutulan datalar bir araya geldiğinde index meydana geliyor. Kalem indexli bir veri aradığımızı düşünelim . Sharda gelen datalar segmentlere kaydediliyor.
Replicate: Shardların tam bir kopyasıdır.
Text Analyzing: 
ES’ün aramanın yalnızca tam eşleşmeler yerine tüm ilgili sonuçları döndürdüğü tam metin araması gerçekleştirmesini sağlar. 
Text Data => Tokenization => Normalization 
Tokenization: Bu işlemde aranan cümleyi parçalara bölüp indexlersek sorgu dizisindeki terimler ayrı ayrı aranabilir.
Tokenization işleminde parçalara ayırma işlemi gerçekleştiriliyor.
Untokenized string: Bugün hava çok sıcaktı. Sıcak havalarda çalışılmaz.
Tokenized string: Bugün,hava,çok,sıcaktı,sıcak,havalarda,çalışılmaz.
Normalization işleminde ise tokenization işlemi gerçekleşen verilere zenginleştirme işlemi yapılır. Nedir zenginleştirme işlemi ? Kelimenini kökünü alma , eş anlamlısını ekleme gibi. Burada zenginleştirilen veriler inverted index tablosuna kaydedilir.
Inverted Index
Relevancy Score
Best Match relevancy algoritm(BM25) ile aranan kelime ile dönen data arasındaki ilişkiyi ifade eder. Ne kadar yüksek ise o kadar alakalı sonuç dönmüştür. 
API
(Create Document) Indexing API => 
<HTTP Metot type><Server:Port>/<IndexName(Table)>/_doc/<Doc_ID(Primary Key)>
PUT products/_doc/1
{
  "name":"Iphone14",
  "rating":8.5,
  "published":true,
  "category":"mobile phones",
  "price":{
    "usd":2500,
    "eur":2000
  }
}
Retrieve Document => GET products/_doc/1 ile hem meta data hem document geliyor
GET products/_source/1 ile documente ulaşıyoruz. Meta datalar gelmez.
Response body’sinde işlem hakkında bilgi veren kısımlar mevcut. Version kısmı kaç defa güncellendiği bilgisini saklarken, _seq_no değeri kaç defa işlem yapıldığını gösterir. _primary_text ifadesi ise replica shardlardan kaçının primary shard olduğunu gösteriyor.
POST işlemi => Post işleminde id değeri veremiyoruz. POST products/_doc {body } oluşturursak elasticsearch id değerini random algoritmasıyla oluşturuyor. 
Verilerin indexlenme sürecini inceleyelim =>
Index ES’de belirli bir veri kümesini temsil eder. Veriler bu index içerisinde saklanır ve organize edilir. Index veritabanındaki tabloya benzer.
Document: ES’de veri JSON formatında document olarak depolanır.
Mapping: Her document bir index’e eklenmeden önce mapping tarafından tanımlanan şemaya göre işlenir. 
In Memory Buffer: Documentlar ilk olarak in memory buffer’a yazılır. Bu bellek tabanlı yapı hızlı yazma işlemleri için kullanılır. 
Translog: Aynı zamanda veri translog adı verilen bir işlem günlüğüne yazılır. Bu veri kaybını önlemek ve sistemin düzgün çalışmasını sağlamak için kullanılır.
Flush: In memory buffer dolduğunda ya da belirli bir süre geçtiğinde veriler segment adı verilen daha kalıcı bir depolama birimine yazılır. Bu işleme flush adı verilir. 
Segment: Segmentler disk üzerinde depolanan immutability yapıdadır. Her segment bir shard içerisinde yer alır ve arama sırasında kullanılır. 
Shard:Bir index, büyük veri hacimlerini yönetmek ve performansı arttırmak için birden fazla shard’a bölünür. Her shard mini bir index olarak düşünülebilir ve hepsi kendi başına ayrı bir arama motoru gibidir. Bu, veri paralel olarak işlenebilir ve daha büyük veri kümeleri yönetilebilir.
Primary ve replica shard: Bir index oluşturulurken her shard’ın bir primary ve bir veya daha fazla replica shardı olabilir. Primary shard veriyi ilk depolayan shard’dır. Replica shard ise verinin yedek kopyasını tutar. Bu hem hata toleransını hem de okuma performansını arttırır.
Node: Elasticsearch'teki bir node, bir Elasticsearch instansını temsil eder. Birden fazla node, bir cluster içinde bir araya gelerek çalışır. Cluster'daki her node, birden fazla shard'ı barındırabilir ve bu shard'lar üzerinde sorguları işleyebilir.
Master Node: Cluster'ı yönetir ve indekslerin ve shard'ların dağıtımını kontrol eder.
Data Node: Verilerin saklandığı ve aramaların işlendiği node'dur.
Client Node: Sorguları alır, uygun data node'lara yönlendirir ve sonuçları birleştirir.

PUT products/_settings
{
  "index":{"refresh_interval":"5s"}
} refresh interval normalde 1 saniyeydi. Bu kod bloğu ile 5 saniyeye ayarlandı.
Aşağıdaki kod bloğu ile defaultta false olan refresh değeri false’a dönüyor. Daha hızlı bir şekilde eritebilmesine imkan sağlıyor. 
PUT products/_doc/20?refresh=true
{
  "name":"Iphone14",
  "rating":8.5,
  "published":true,
  "category":"mobile phones",
  "price":{
    "usd":2500,
    "eur":2000
  }
}
Updating Documents 
[POST]: <index_name>/_update/<id>
POST products/_update/1
{
  "doc":{  }}
Deleting Documents
[DELETE] <index_name>/_doc/<id>
DELETE products/_doc/1
Retrieving documents with HEAD method Type
Sadece datanın var olup olmadığını kontrol etmek istersek bu metodu kullanıyoruz.
HEAD product/_doc/1
Retrieving multiple documents with _mget
GET products/_mget{
“ids”:[“1”,”2”]
}
GET products/_search{
“query”:{“match_all”:{}} }
Custom response with no metadata 
GET products/_source/1
Custom response with _source includes or _source excludes
GET products/_doc/1?_source_includes=name,stock,category
İnclude ile istediğin propertyleri alabilirsin. Exclude ile istemediğin propertyleri çıkartabilirsin.
Data Types
 

Object(Complex) Data Type
Benim göndereciğ tip data belliyse ve göndereceğim data üzerinde detaylı arama yapacaksam default objecti kullanalım.Göndereceğimiz datanın propertylerini tek tek belirleyebiliyoruz. 
PUT email
{
  "mappings": {
    "properties": {
      "from":{"type":"keyword"},
      "to":{"type":"keyword"},
      "attachment":{
        "properties": {
          "name":{"type":"keyword"},
          "type":{"type":"keyword"}
        }}}}}
Flattened Data Type
Property’leri hakkında tam bilgim yoksa ve verilerde detaylı bir arama yapmayacaksam Flattened Data type kullanılabilir. Göndereceğimiz datayı bir bütün olarak keyword tipinde alıyordu. O yüzden büyüktür küçüktür gibi arama sorgu yapmak mümkün değil.
Nested Data Type
Özelleşmiş data tipleri olarak düşüneceğiz. Object’deki her şeyi yapabiliyoruz fakat arama kısmında bir fark var. 
Örnek verecek olursak
PUT user/_doc/1 {
“userId”:”1”,
“user”:[
{“name”:”ahmet”,”surname”:”yılmaz”},
{“name”:”mehmet”,”surname”:”güneş”}]}
User.name =”ahmet” ve user.surname =”güneş” olan bir veri arıyoruz.
Eğer object veri tipinde olsaydı ahmet adını bulacaktı. Sonrasında güneş soyadına rastladığı anda aranan veriyi bulduğunu düşünerek dönecekti.Çünkü object her bir propertyi birbirinden bağımsız olarak düşünüyor. 
Nested type’da bu karmaşa olmayacak. 
Join Data Type
Nadir senaryolarda karşımıza çıkacağı için detaylı incelemeyeceğiz. Ama hangi probleme çözüm üretmek için çıktığını açıklayacağız.
Index tablosu içerisinde tabloları birbiri ile eşleştiriyor. Parent child ilişkisi var.
Mapping
Schema(kaydedilmek istenen data tipleri) oluşturma süreci mapping olarak adlandırılır.
PUT products/_doc/1
{
“name”:”pen1”,
“price”: 38.99,
“created”:”2023-15-02”,
“stocks”:{“warehouse1”:100,”warehouse2”:200}}
Products isminde yeni bir index oluşur. Yeni bir schema oluşur. Document kalıcı olarak kaydedilir. Daha sonraki işlemlerde ilk 2 adım gerçekleşmez.
2 çeşit Mapping var. Dynamic mapping ve explicit mapping.
PUT products
{
  "mappings": {
    "properties": {
      "name":{"type": "text"},
      "price":{"type": "long"},
      "stock_no":{"type":"keyword"},
      "warehouse":{
        "properties": {
          "germany":{"type":"integer"},
          "turkey":{"type":"integer"}
        }}}}}
Maplerken bir diğer önemli konu ise şu. Aramak istediğimiz değer  “.NET 8 ile gelen yenilikler”. Arama işlemini yaparken .NET yazdığımızı düşünelim. Eğer type’i keyword ise asla aradığımızı bulamayız. O yüzden propertylerin tiplerini tanımlarken hem text hem de keyword şeklinde tanımlıyoruz.
PUT products/_mapping
{ "name":{
    "type":"text",
    "fields":{
      "keyword":{
        "type":"keyword"}}}}
Re-indexing Mapping
Elasticsearch tanımlanan propertylerin veri tiplerini update etmemize izin vermiyor.

PUT products2
{
  "mappings": {
    "properties": {
        "color": {
          "type": "text"
        },
        "name": {
          "type": "keyword"
        },
        "price": {
          "type": "double"
        },
        "stock_no": {
          "type": "keyword"
        },
        "stokc_no": {
          "type": "text",
          "fields": {
            "keyword": {
              "type": "keyword",
              "ignore_above": 256
            }
          }
        },
        "warehouse": {
          "properties": {
            "germany": {
              "type": "integer"
            },
            "turkey": {
              "type": "integer"
            }
          }
        }
      }
  }
}

Öncelikle yeniden indexleme işlemi yapıyoruz. Sonrasında oluşturduğumuz yeni index’e 
POST /_reindex
{
  "source": {
    "index": "products"
  },
  "dest": {
    "index": "product2"
  }
} ile verileri aktarıyoruz. Aktarılacak verilen boyutuna göre tamamlanma süresi değişebilir.
Searching Types
Structured Types date between , rating(1-5), price(>1000 veya <5000) gibi arama filtrelerini örnek gösterebiliriz.
Unsturtured Type full text search olarak da adlandırılıyor. Tipi eğer text ise analiz sürecinden geçiyor. Keyword ise analiz sürecinden geçmiyor. Score değerleri döner. En yüksek skorlu değer döner . 
Search EndPoint
Get/Post 
Query string ya da request body ile search parameter işlemi
Query string => URI request method
Request Body => Query DSL(Best practices) Parametreleri request’in body’sinde yolluyoruz.
Query String 
get kibana_sample_data_ecommerce/_search?q=user:yahya
Request Body
Get kibana_sample_data_ecommerce/_search
{
  "query":{
    "match": {
      "user": "yahya"}}}
Search Context
Query Context = relevancy score
Filter Context = no relevancy score
Unstructered yapı üzerinde arama yapıyorsak(haber sitesi,blog sitesi vb…) aradığımız datanın çıkan sonuçlarla ne kadar alakalı olduğu ile ilgili bir score değeri geliyor.
Bir de filter context üzerinden sorgu yaparsak bize skor değeri vermez. Daha çok structured yapılarda filter context uygulanır. Filter keyword’ünü kullanırsanız daha iyi performans elde edebilmek için cacheleme işlemi yapılır. Veriler aynı zamanda cache’den gelir. 
Search Response
Bir search endpointine istek yaptığımızda dönen response inceleyelim.
 
Term Level Query
Term-level queries structured datalarda kullanılır. Term level queries structured datalarda ifade arıyoruz. Data range , IP adres fiyat, producId gibi değerler örnek gösterilebilir. Tam uyuşma şartı vardır. Number, date, IP, Keyword type(SGK no, TC no).
Get kibana_sample_data_ecommerce/_search
{
 "query":{
   "term": {
     "customer_first_name.keyword": {
       "value": "Sonya"}}}}
"query": {
    "term": {
      "customer_first_name.keyword": {
        "value": "sonya",
        "case_insensitive":true}}
Terms ile aratırsak “customer_first_name.keyword “: [“Youssef”,”Sonya”]
Ids=> id keywordü ile arama 
Query => ids => “values” : [“id1”,”id2”]; id1 ve id2 bulunan değerleri getirecek.
Exist => quety => exists => “fields”:”user” ya da “order_id” propertylerin olup olmadığını kontrol ediyor.
Prefix=> sağlanan alanda belli bir önek barındıran sorgu sonuçlarını getirir. İlk karakterden itibaren kontrol eder. 
Range query => range query adı üstünde belirli bir değer aralığına düşen sonuçları döndüren bir yapı
Gt => greater than

- Gte => Greater than or equal
Lt => less than
Lte => Less then or equal
Wildcard query => Bir kelimenin ortasından bilemediğiniz kelimeler olabilir. Bu sorunu aşmak için ortaya atılmış bir yöntemdir. 
Lam* => Lam ile başlıyor sonrasında ne olursa olsun
Lam*rt => Lam ile başlayan sonu rt 
Lambe?t => tek bir karakter unutulduysa
Fuzzy Query => Bir kelime yazıyorsun. Kaç harf hatası belirtirsen o kadar harf farklı olan dataları getiriyor.
Query => fuzzy => customer_first_name.keyword : “value”:”tephanie” //Stephanie{fuzziness:1}
Pagination
Full Text Queries
Match Query =>  get metodu => query => match => category:”shoes” burada kelimenin tam ismini yazmamız gerekiyor.
"query": {"match": {"customer_full_name":{"query": "Yahya goodwin","operator": "and"
Ve  "query": {"match": {"customer_full_name": "Yahya Goodwin"
Multi Match Query
"query": {
    "multi_match": {"query": "Sultan Al Moran","operator": "and", "fuzziness": "auto", 
      "fields": ["customer_first_name","customer_full_name","customer_last_name"]
Match Boolean Prefix Query
Son kelimeyi prefix olarak alıyor. Örneğin Hüseyin Serhan Kunt. Arama yaparken Kunt… or Serhan or Hüseyin 
Match Phrase Query
Öbek kelimeleri aramak için kullanıyoruz. İsimlerde sıralama önemliyse bu query’i kullanıyoruz.
Normal Match query’den farkını örnek ile açıklayayım.Database’de Hüseyin Serhan Kunt adlı bir veri olsun. Arama ekranına Hüseyin Serhan blabla Kunt yazarsan match query db’deki veriyi getirir. Ama Match Phrase query ile ararsan sırasında bir farklılık görürse o veriyi getirmez.
Aggregatgions Types
Bucket Aggregations
Terms Aggregations => 
Range Aggregations => 
WEB API ve NEST Kütüphanesi


