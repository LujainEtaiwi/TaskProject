// Define the cache name
const CACHE_NAME = 'my-blazor-app-cache';

// List of URLs to cache
const urlsToCache = [
  '/',
  '/index.html',
  '/css/site.css',
  '/js/site.js',
  // Add more URLs as needed
];

// Install event: Cache assets when service worker is installed
self.addEventListener('install', event => {
  event.waitUntil(
    caches.open(CACHE_NAME)
      .then(cache => cache.addAll(urlsToCache))
  );
});

// Fetch event: Serve cached assets if available, otherwise fetch from network
self.addEventListener('fetch', event => {
  event.respondWith(
    caches.match(event.request)
      .then(response => {
        // Cache hit - return response
        if (response) {
          return response;
        }

        // Not in cache - fetch from network
        return fetch(event.request);
      })
  );
});
