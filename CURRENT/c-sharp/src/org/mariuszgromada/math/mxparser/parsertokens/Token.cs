/*
 * @(#)Token.cs        5.0.0    2022-04-10
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

namespace org.mariuszgromada.math.mxparser.parsertokens {
	/**
	 * Token recognized by mXparser after string tokenization process.
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
	public class Token {
		/**
		 * Indicator that token was not matched
		 */
		public const int NOT_MATCHED = KeyWord.NO_DEFINITION;
		/**
		 * String token
		 */
		public String tokenStr;
		/**
		 * Key word string (if matched)
		 */
		public String keyWord;
		/**
		 * Token identifier
		 */
		public int tokenId;
		/**
		 * Token type
		 */
		public int tokenTypeId;
		/**
		 * Token level
		 */
		public int tokenLevel;
		/**
		 * Token value if number
		 */
		public double tokenValue;
		/**
		 * If token was not matched then
		 * looksLike functionality is trying asses
		 * the kind of token
		 */
		public String looksLike;
		/**
		 * Verification if the token is a left unary operator.
		 *
		 * @return true in case token is unary left operator,
		 * otherwise returns false
		 */
		public bool isUnaryLeftOperator() {
			if (tokenTypeId == Operator.TYPE_ID) {
				if (tokenId == Operator.SQUARE_ROOT_ID) return true;
				if (tokenId == Operator.CUBE_ROOT_ID) return true;
				if (tokenId == Operator.FOURTH_ROOT_ID) return true;
			}
			if (tokenTypeId == BooleanOperator.TYPE_ID) {
				if (tokenId == BooleanOperator.NEG_ID) return true;
			}
			if (tokenTypeId == BitwiseOperator.TYPE_ID) {
				if (tokenId == BitwiseOperator.COMPL_ID) return true;
			}
			return false;
		}
		/**
		 * Verification if the token is a right unary operator.
		 *
		 * @return true in case token is unary right operator,
		 * otherwise returns false
		 */
		public bool isUnaryRightOperator() {
			if (tokenTypeId == Operator.TYPE_ID) {
				if (tokenId == Operator.FACT_ID) return true;
				if (tokenId == Operator.PERC_ID) return true;
			}
			return false;
		}
		/**
		 * Verification if the token is a left parenthesis.
		 *
		 * @return true in case token is a left parenthesis,
		 * otherwise returns false
		 */
		public bool isLeftParenthesis() {
			if (tokenTypeId == ParserSymbol.TYPE_ID && tokenId == ParserSymbol.LEFT_PARENTHESES_ID)
				return true;
			else
				return false;
		}
		/**
		 * Verification if the token is a right parenthesis.
		 *
		 * @return true in case token is a right parenthesis,
		 * otherwise returns false
		 */
		public bool isRightParenthesis() {
			if (tokenTypeId == ParserSymbol.TYPE_ID && tokenId == ParserSymbol.RIGHT_PARENTHESES_ID)
				return true;
			else
				return false;
		}
		/**
		 * Verification if the token is an identifier.
		 *
		 * @return true in case token is an identifier,
		 * otherwise returns false
		 */
		public bool isIdentifier() {
			if (tokenTypeId == Constant.TYPE_ID ||
					tokenTypeId == ConstantValue.TYPE_ID ||
					tokenTypeId == Unit.TYPE_ID ||
					tokenTypeId == Argument.TYPE_ID)
				return true;
			else
				return false;
		}
		/**
		 * Verification if the token is a binary operator.
		 *
		 * @return true in case token is a binary operator,
		 * otherwise returns false
		 */
		public bool isBinaryOperator() {
			if (isUnaryLeftOperator()) return false;
			if (isUnaryRightOperator()) return false;
			if (tokenTypeId == BinaryRelation.TYPE_ID) return true;
			if (tokenTypeId == BitwiseOperator.TYPE_ID) return true;
			if (tokenTypeId == BooleanOperator.TYPE_ID) return true;
			if (tokenTypeId == Operator.TYPE_ID) {
				if (	tokenId != Operator.SQUARE_ROOT_ID
						&& tokenId != Operator.CUBE_ROOT_ID
						&& tokenId != Operator.FOURTH_ROOT_ID
						&& tokenId != Operator.FACT_ID
						&& tokenId != Operator.PERC_ID
				)  return true;
			}
			return false;
		}
		/**
		 * Verification if the token is a parameter separator.
		 *
		 * @return true in case token is a parameter separator,
		 * otherwise returns false
		 */
		public bool isParameterSeparator() {
			if (tokenTypeId == ParserSymbol.TYPE_ID && tokenId == ParserSymbol.COMMA_ID)
				return true;
			else
				return false;
		}
		/**
		 * Verification if the token is a number.
		 *
		 * @return true in case token is a number,
		 * otherwise returns false
		 */
		public bool isNumber() {
			if (tokenTypeId == ParserSymbol.NUMBER_TYPE_ID && tokenId == ParserSymbol.NUMBER_ID)
				return true;
			else
				return false;
		}
		/**
		 * Verification if the token is represented by a special name in the form [...].
		 *
		 * @return true in case token is represented by a special name in the form [...],
		 * otherwise returns false
		 */
		public bool isSpecialTokenName() {
			if (tokenStr.Length == 0) return false;
			if (tokenStr[0] == '[') return true;
			else return false;
		}
		/**
		 * Verification if the token represents unicode root operator
		 *
		 * @return true in case token represents unicode root operator
		 * otherwise returns false
		 */
		public bool isUnicodeRootOperator() {
			if (tokenTypeId == Operator.TYPE_ID) {
				if (tokenId == Operator.SQUARE_ROOT_ID) return true;
				if (tokenId == Operator.CUBE_ROOT_ID) return true;
				if (tokenId == Operator.FOURTH_ROOT_ID) return true;
			}
			return false;
		}
		/**
		 * Creates token representing multiplication operator.
		 *
		 * @return token representing multiplication operator.
		 */
		public static Token makeMultiplyToken() {
			Token multiplyToken = new Token();
			multiplyToken.tokenTypeId = Operator.TYPE_ID;
			multiplyToken.tokenId = Operator.MULTIPLY_ID;
			multiplyToken.tokenStr = Operator.MULTIPLY_STR;
			return multiplyToken;
		}

		/**
		 * Default constructor
		 */
		public Token() {
			tokenStr = "";
			keyWord = "";
			tokenId = NOT_MATCHED;
			tokenTypeId = NOT_MATCHED;
			tokenLevel = -1;
			tokenValue = Double.NaN;
			looksLike = "";
		}
		/**
		 * Token cloning.
		 */
		public Token clone() {
			Token token = new Token();
			token.keyWord = keyWord;
			token.tokenStr = tokenStr;
			token.tokenId = tokenId;
			token.tokenLevel = tokenLevel;
			token.tokenTypeId = tokenTypeId;
			token.tokenValue = tokenValue;
			token.looksLike = looksLike;
			return token;
		}
	}
}