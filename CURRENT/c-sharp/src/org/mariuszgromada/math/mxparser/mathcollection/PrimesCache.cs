/*
 * @(#)PrimesCache.cs        5.0.0    2022-04-10
 *
 * Copyright 2010 - 2022 MARIUSZ GROMADA. All rights reserved.
 *
 * PRODUCT: MathParser.org-mXparser
 * LICENSE: DUAL LICENSE
 *
 * SOFTWARE means source code and/or binary form and/or documentation.
 *
 * BY INSTALLING, COPYING, OR OTHERWISE USING THE SOFTWARE, YOU AGREE TO BE
 * BOUND BY ALL OF THE TERMS AND CONDITIONS OF THE DUAL LICENSE AGREEMENT.
 *
 * MARIUSZ GROMADA provides MathParser.org-mXparser SOFTWARE under the
 * DUAL LICENSE model designed to meet the needs of both Non-Commercial Use
 * as well as Commercial Use.
 *
 * NON-COMMERCIAL USE means any use or activity where a fee is not charged
 * and the purpose is not the sale of a good or service, and the use or
 * activity is not intended to produce a profit. NON-COMMERCIAL USE examples:
 *
 * 1. Free Open-Source Software ("FOSS").
 * 2. Non-commercial use in research, scholarly and education.
 *
 * COMMERCIAL USE means any use or activity where a fee is charged or the
 * purpose is the sale of a good or service, or the use or activity is
 * intended to produce a profit. COMMERCIAL USE examples:
 *
 * 1. OEMs (Original Equipment Manufacturers).
 * 2. ISVs (Independent Software Vendors).
 * 3. VARs (Value Added Resellers).
 * 4. Other distributors that combine and distribute commercially licensed
 *    software.
 *
 * IN CASE YOU WANT TO USE THE SOFTWARE COMMERCIALLY, YOU MUST PURCHASE
 * THE APPROPRIATE LICENSE FROM "INFIMA IWONA GLOWACKA-GROMADA", ONLINE
 * STORE ADDRESS: HTTPS://PAYHIP.COM/INFIMA
 *
 * NON-COMMERCIAL LICENSE
 *
 * Redistribution and use of the PRODUCT in source and/or binary forms, with
 * or without modification, are permitted provided that the following
 * conditions are met:
 *
 * 1. Redistributions of source code must retain unmodified content of the
 *    entire MathParser.org-mXparser DUAL LICENSE, including definition of
 *    NON-COMMERCIAL USE, definition of COMMERCIAL USE, NON-COMMERCIAL
 *    LICENSE conditions, COMMERCIAL LICENSE conditions, and the following
 *    DISCLAIMER.
 * 2. Redistributions in binary form must reproduce the entire content of
 *    MathParser.org-mXparser DUAL LICENSE in the documentation and/or other
 *    materials provided with the distribution, including definition of
 *    NON-COMMERCIAL USE, definition of COMMERCIAL USE, NON-COMMERCIAL
 *    LICENSE conditions, COMMERCIAL LICENSE conditions, and the following
 *    DISCLAIMER.
 *
 * COMMERCIAL LICENSE
 *
 *  1. Before purchasing a commercial license, MARIUSZ GROMADA allows you to
 *     download, install and use up to three copies of the PRODUCT to perform
 *     integration tests, confirm the quality of the PRODUCT and its
 *     suitability. The testing period should be limited to one month. Tests
 *     should take place via test environments. The purpose of the tests must
 *     not be to generate profit.
 *  2. Provided that you purchased a license from "INFIMA IWONA GLOWACKA-GROMADA"
 *     (online store address: https://payhip.com/INFIMA), you comply with all
 *     below terms and conditions, and you have acknowledged and understood the
 *     following DISCLAIMER, MARIUSZ GROMADA grants you a nonexclusive license
 *     including the following rights:
 *  3. In case you purchased a "Single License" You can install and use the
 *     PRODUCT from one workstation.
 *  4. Additional copies of the PRODUCT can be installed and used from more
 *     than one workstation; however, this number is limited to the number of
 *     copies purchased as per order.
 *  5. In case you purchased a "Site License", the PRODUCT can be installed
 *     and used from all workstations located at your premises.
 *  6. You may incorporate the unmodified PRODUCT into your own products and
 *     software.
 *  7. If you purchased a license with the "Source Code" option, you may modify
 *     the PRODUCT's source code and incorporate the modified source code into
 *     your own products and / or software.
 *  8. You may distribute your product and / or software with the incorporated
 *     PRODUCT royalty-free.
 *  9. You may make copies of the PRODUCT for backup and archival purposes.
 * 10. MARIUSZ GROMADA reserves all rights not expressly granted to you in
 *     this agreement.
 *
 * CONTACT
 * - e-mail: info@mathparser.org
 * - website: https://mathparser.org
 * - source code: https://github.com/mariuszgromada/MathParser.org-mXparser
 * - online store: https://payhip.com/INFIMA
 *
 * DISCLAIMER
 *
 * THIS SOFTWARE IS PROVIDED BY MARIUSZ GROMADA "AS IS" AND ANY EXPRESS OR
 * IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
 * OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
 * IN NO EVENT SHALL MATHPARSER.ORG MARIUSZ GROMADA OR CONTRIBUTORS BE LIABLE
 * FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
 * DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
 * CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
 * OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE
 * USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 *
 * THE VIEWS AND CONCLUSIONS CONTAINED IN THE SOFTWARE AND DOCUMENTATION ARE
 * THOSE OF THE AUTHORS AND SHOULD NOT BE INTERPRETED AS REPRESENTING OFFICIAL
 * POLICIES, EITHER EXPRESSED OR IMPLIED, OF MARIUSZ GROMADA.
 */
using System;

namespace org.mariuszgromada.math.mxparser.mathcollection {
	/**
	 * Class for generating prime numbers cache using
	 * Eratosthenes Sieve.
	 *
	 * @author         <b>Mariusz Gromada</b><br>
	 *                 <a href="https://mathparser.org" target="_blank">MathParser.org - mXparser project page</a><br>
	 *                 <a href="https://github.com/mariuszgromada/MathParser.org-mXparser" target="_blank">mXparser on GitHub</a><br>
	 *                 <a href="https://payhip.com/INFIMA" target="_blank">INFIMA place to purchase a commercial MathParser.org-mXparser software license</a><br>
	 *                 <a href="mailto:info@mathparser.org">info@mathparser.org</a><br>
	 *                 <a href="https://scalarmath.org/" target="_blank">ScalarMath.org - a powerful math engine and math scripting language</a><br>
	 *                 <a href="https://play.google.com/store/apps/details?id=org.mathparser.scalar.lite" target="_blank">Scalar Lite</a><br>
	 *                 <a href="https://play.google.com/store/apps/details?id=org.mathparser.scalar.pro" target="_blank">Scalar Pro</a><br>
	 *                 <a href="https://mathspace.pl" target="_blank">MathSpace.pl</a><br>
	 *
	 * @version        5.0.0
	 */
	[CLSCompliant(true)]
	public class PrimesCache {
		/**
		 * Default range of integer to store in cache
		 */
		public const int DEFAULT_MAX_NUM_IN_CACHE = 10000000;
		/**
		 * Empty cache status
		 */
		public const bool CACHE_EMPTY = false;
		/**
		 * Cache ready to use
		 */
		public const bool CACHING_FINISHED = true;
		/**
		 * Indicator if given number is a prime
		 */
		public const int IS_PRIME = 1;
		/**
		 * Indicator if given number is not a prime
		 */
		public const int IS_NOT_PRIME = 0;
		/**
		 * Indicator that the value is not stored
		 * in cache
		 */
		public const int NOT_IN_CACHE = -1;
		/**
		 * Primes between 0 ... and ... maximumNumberInCache
		 * will be cached
		 */
		internal int maxNumInCache;
		/**
		 * Number of cached prime numbers
		 */
		internal int numberOfPrimes;
		/**
		 * Time in seconds showing
		 * how long did it take to finalize prime numbers
		 * caching.
		 */
		internal double computingTime;
		/**
		 * Caching process status
		 */
		internal bool cacheStatus;
		/**
		 * Integers table to store number and indicate
		 * whether they are prime or not
		 */
		internal bool[] isPrime;
		/**
		 * Internal flag marking that primes cache initialization was successful;
		 */
		bool initSuccessful;
		/**
		 * Eratosthenes Sieve implementation
		 */
		private void EratosthenesSieve() {
			long startTime = mXparser.currentTimeMillis();
			try {
				int size = maxNumInCache+1;
				if (size <= 0) {
					numberOfPrimes = 0;
					maxNumInCache = 0;
					initSuccessful = false;
					long endTime = mXparser.currentTimeMillis();
					computingTime = (endTime - startTime)/1000.0;
					return;
				}
				isPrime = new bool[size];
				numberOfPrimes = 0;
				/*
				 * Initially assume all integers are primes
				 */
				isPrime[0] = false;
				isPrime[1] = false;
				for (int i = 2; i <= maxNumInCache; i++) {
					isPrime[i] = true;
					if (mXparser.isCurrentCalculationCancelled()) return;
				}
				/*
				 * Sieve of Eratosthenes - marking non-primes
				 */
				for (int i = 2; i*i <= maxNumInCache; i++) {
					if (mXparser.isCurrentCalculationCancelled()) return;
					if (isPrime[i] == true)
						for (int j = i; i*j <= maxNumInCache; j++) {
							isPrime[i*j] = false;
							if (mXparser.isCurrentCalculationCancelled()) return;
						}
				}
				initSuccessful = true;
			} catch (OutOfMemoryException) {
				initSuccessful = false;
			} finally {
				long endTime = mXparser.currentTimeMillis();
				computingTime = (endTime - startTime)/1000.0;
			}
		}
		/**
		 * Counting found primes
		 */
		private void countPrimes() {
			for (int i = 0; i <= maxNumInCache; i++) {
				if (isPrime[i] == true) numberOfPrimes++;
				if (mXparser.isCurrentCalculationCancelled()) return;
			}
		}
		/**
		 * Default constructor - setting prime cache for a default range if integers
		 */
		public PrimesCache() {
			initSuccessful = false;
			cacheStatus = CACHE_EMPTY;
			maxNumInCache = DEFAULT_MAX_NUM_IN_CACHE;
			EratosthenesSieve();
			if (initSuccessful) {
				countPrimes();
				cacheStatus = CACHING_FINISHED;
			} else {
				maxNumInCache = 0;
				numberOfPrimes = 0;
			}
		}
		/**
		 * Constructor - setting prime cache for a given range if integers
		 * @param maxNumInCache Range of integers to be stored in prime cache
		 */
		public PrimesCache(int maxNumInCache) {
			if (maxNumInCache > 2)
				this.maxNumInCache = Math.Min(maxNumInCache, int.MaxValue - 1);
			else
				this.maxNumInCache = DEFAULT_MAX_NUM_IN_CACHE;
			initSuccessful = false;
			cacheStatus = CACHE_EMPTY;
			maxNumInCache = DEFAULT_MAX_NUM_IN_CACHE;
			EratosthenesSieve();
			if (initSuccessful) {
				countPrimes();
				cacheStatus = CACHING_FINISHED;
			} else {
				maxNumInCache = 0;
				numberOfPrimes = 0;
			}
		}
		/**
		 * Returns computing time of Eratosthenes Sieve
		 * @return Computing time in seconds
		 */
		public double getComputingTime() {
			return computingTime;
		}
		/**
		 * Returns cache status
		 * @return PrimesCache.CACHE_EMPTY or PrimesCache.CACHING_FINISHED;
		 */
		public bool getCacheStatus() {
			return cacheStatus;
		}
		/**
		 * Returns number of found primes.
		 * @return Number of found primes.
		 */
		public int getNumberOfPrimes() {
			return numberOfPrimes;
		}
		/**
		 * Returns cache range.
		 * @return Maximum integera number in cache/
		 */
		public int getMaxNumInCache() {
			return maxNumInCache;
		}
		/**
		 * Check whether given number is prime
		 * @param n Given integer number.
		 * @return PrimesCache.IS_PRIME or PrimesCache.IS_NOT_PRIME or PrimesCache.NOT_IN_CACHE
		 */
		public int primeTest(int n) {
			if (n <= 1) return IS_NOT_PRIME;
			if ( (n <= maxNumInCache) && (cacheStatus = CACHING_FINISHED) )
				if ( isPrime[n] == true)
					return IS_PRIME;
				else
					return IS_NOT_PRIME;
			else
				return NOT_IN_CACHE;
		}
		/**
		 * Returns true in case when primes cache initialization was successful,
		 * otherwise returns false.
		 *
		 * @return Returns true in case when primes cache initialization was successful,
		 * otherwise returns false.
		 */
		public bool isInitSuccessful() {
			return initSuccessful;
		}
		/**
		 * Gets underlying primes cache boolean table
		 * @return Underlying primes cache boolean table
		 */
		bool[] getPrimes() {
			return isPrime;
		}
	}
}